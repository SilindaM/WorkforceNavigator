namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using Domain.Dtos.General;
  using Domain.Dtos.GeneralAdmin;
  using Domain.Enties.TimeSheets;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Linq;
  using System.Threading.Tasks;
  using Microsoft.AspNetCore.Identity;
  using Domain.Account;
  using Domain.Dtos.LeaveTypes.Teams;
  using Microsoft.AspNet.Identity.EntityFramework;
  using IdentityRole = Microsoft.AspNetCore.Identity.IdentityRole;

  public class TeamService : ITeamInterface
  {
    private readonly DataContext dataContext;
    private readonly UserManager<ApplicationUser> userManager;

    public TeamService(DataContext dataContext, UserManager<ApplicationUser> userManager)
    {
      this.dataContext = dataContext;
      this.userManager = userManager;
    }
    public async Task<GeneralServiceResponseDto> UpdateTeamMembership(string username, int? teamId = null)
    {
      try
      {
        var assignee = dataContext.Users.FirstOrDefault(x => x.UserName == username);

        if (assignee == null)
        {
          return ResponseHelper.CreateResponse(false, 400, "Username not found.");
        }

        // If teamId is provided, update it; otherwise, remove the member from the team
        if (teamId.HasValue)
        {
          assignee.TeamId = teamId.Value;
        }
        else
        {
          assignee.TeamId = null; // Signifies removal
        }

        await dataContext.SaveChangesAsync();

        // Determine the action based on teamId: added or removed
        var action = teamId.HasValue ? "added" : "removed";

        // Return response with appropriate message
        return ResponseHelper.CreateResponse(true, 200, $"Member {action} successfully.");
      }
      catch (Exception ex)
      {
        return ResponseHelper.CreateResponse(false, 500, $"An error occurred: {ex.Message}");
      }
    }

    public async Task<IEnumerable<TeamMemberDetailsDto>> GetAllTeamsWithMembersAsync()
    {
      try
      {
        var teamsWithMembers = (from tm in dataContext.Teams
                                join u in dataContext.Users on tm.Id equals u.TeamId
                                join jt in dataContext.JobTitles on u.JobTitleId equals jt.Id
                                select new
                                {
                                  TeamName = tm.TeamName,
                                  Member = new MemberDetails
                                  {
                                    JobTitle = jt.Title,
                                    FirstName = u.FirstName,
                                    LastName = u.LastName
                                  }
                                }).ToList();

        // Group by TeamName and select the first member's details for each group
        var teams = teamsWithMembers.GroupBy(t => t.TeamName)
                                   .Select(g => new TeamMemberDetailsDto
                                   {
                                     TeamName = g.Key,
                                     MemberDetails = g.Select(m => m.Member).ToList() // Convert to list to maintain the structure
                                   }).ToList();

        return teams;
      }
      catch (Exception ex)
      {
        return Enumerable.Empty<TeamMemberDetailsDto>(); // Return an empty list in case of an error
      }
    }

    public async Task<GeneralServiceResponseDto> CreateTeam(TeamDto teamDto)
    {
      try
      {
        // Check if a team with the same name already exists
        var existingTeam =  dataContext.Teams.FirstOrDefault(t => t.TeamName == teamDto.TeamName);

        if (existingTeam != null)
        {
          return ResponseHelper.CreateResponse(false, 400, "A team with this name already exists.");
        }

        // Check if the teamLeader is a Manager
        var teamLeader = await userManager.FindByNameAsync(teamDto.TeamLeader);

        if (teamLeader == null)
        {
          return ResponseHelper.CreateResponse(false, 400, "User Name  not found or invalid.");
        }

        if (!await IsUserManager(teamDto.TeamLeader))
        {
          return ResponseHelper.CreateResponse(false, 403, "The assigned user does not qualify to be team leader");
        }

        // Create a new team entity and populate it with data from the DTO
        var newTeam = new Team
        {
          TeamName = teamDto.TeamName,
          TeamLeader = teamDto.TeamLeader,
          Description = teamDto.Description
        };

        // Add the new team to the data context
        await dataContext.Teams.AddAsync(newTeam);

        // Save changes to the database
        await dataContext.SaveChangesAsync();

        // Return a success response
        return ResponseHelper.CreateResponse(true, 201, "Team created successfully.");
      }
      catch (Exception ex)
      {
        // Return an error response in case of an exception
        return ResponseHelper.CreateResponse(false, 500, $"An error occurred: {ex.Message}");
      }
    }

    private async Task<bool> IsUserManager(string username)
    {
      try
      {
        // Retrieve the user by username
        var user = await userManager.FindByNameAsync(username);

        if (user == null)
        {
          // User not found
          return false;
        }

        // Check if the user has the Manager role
        return await userManager.IsInRoleAsync(user, "Manager");
      }
      catch (Exception ex)
      {
        // Log or handle the exception as needed
        // For simplicity, returning false if any exception occurs
        return false;
      }
    }
  }
}