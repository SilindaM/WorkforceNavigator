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


  public class TeamService : ITeamInterface
  {
    private readonly DataContext dataContext;
    private readonly IMapper mapper;

    public TeamService(DataContext dataContext,IMapper mapper)
    {
      this.dataContext = dataContext;
      this.mapper = mapper;
    }
    public async Task<GeneralServiceResponseDto> AddTeamMember(int teamId, string userId)
    {
      try
      {
        string assignee = dataContext.Users
                             .Where(x => x.Id == userId)
                             .Select(x => x.Id)
                             .FirstOrDefault();

        if (assignee == null)
        {
          return ResponseHelper.CreateResponse(false, 400, "Username not Found");
        }

        var newTeamMember = new TeamMemberDto
        {
          teamId = teamId,
          userId = userId
        };

        var teamMemberDto = mapper.Map<TeamMember>(newTeamMember);
        dataContext.TeamMembers.Add(teamMemberDto);
        await dataContext.SaveChangesAsync();

        return ResponseHelper.CreateResponse(true, 200, "Member Added Successfully");
      }
      catch (Exception ex)
      {
        // Log the exception and return an appropriate response
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


    public async Task<IEnumerable<TeamDto>> GetAllTeamsWithMembersAsync()
    {
      var teamsWithMembers = await (from tm in dataContext.Teams
                                    join tmm in dataContext.TeamMembers on tm.Id equals tmm.TeamId
                                    join u in dataContext.Users on tmm.UserId equals u.Id
                                    join jt in dataContext.JobTitles on u.JobTitleId equals jt.Id
                                    select new
                                    {
                                      Team = tm,
                                      Member = new MemberDetails
                                      {
                                        JobTitle = jt.Title,
                                        FirstName = u.FirstName,
                                        LastName = u.LastName
                                      }
                                    }).ToListAsync();

      var teams = teamsWithMembers.Select(t => new TeamDto
      {
        Id = t.Team.Id,
        TeamName = t.Team.TeamName,
        Members = new List<MemberDetails> { t.Member }
      }).ToList();

      return teams;
    }

  }
}