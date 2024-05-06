namespace Application.Services
{
  using Application.Helpers;
  using Application.Interfaces;
  using Application.Interfaces.Auth;
  using Application.Services.Auth;
  using AutoMapper;
  using Domain.Dtos.General;
  using Domain.Dtos.GeneralAdmin;
  using Domain.Enties.TimeSheets;
  using Microsoft.EntityFrameworkCore;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using Microsoft.EntityFrameworkCore;
  using Domain.Dtos.LeaveRequest;
  using Microsoft.AspNet.Identity;


  public class TeamService : ITeamInterface
  {
    private readonly DataContext dataContext;

    public TeamService(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }
    public async Task<GeneralServiceResponseDto> AddTeamMember(int teamId, string username)
    {
      try
      {
        var assignee =  dataContext.Users.FirstOrDefault(x => x.UserName == username);

        if (assignee == null)
        {
          return ResponseHelper.CreateResponse(false, 400, "Username not Found");
        }

        assignee.TeamId = teamId;

        await dataContext.SaveChangesAsync();

        return ResponseHelper.CreateResponse(true, 200, "Member Added Successfully");
      }
      catch (Exception ex)
      {
        return ResponseHelper.CreateResponse(false, 500, $"An error occurred: {ex.Message}");
      }
    }



    public Task<GeneralServiceResponseDto> RemoveTeamMember(int teamId, string username)
    {
      throw new NotImplementedException();
    }

    public Task<GeneralServiceResponseDto> UpdateTeamMember(int teamId, string username)
    {
      throw new NotImplementedException();
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
        // Log or handle the exception
        Console.WriteLine($"An error occurred: {ex.Message}");
        return Enumerable.Empty<TeamMemberDetailsDto>(); // Return an empty list in case of an error
      }
    }


  }

}
