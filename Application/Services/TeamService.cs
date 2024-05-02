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
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class TeamService : ITeamInterface
  {
    private readonly DataContext dataContext;
    private readonly IMapper mapper;

    public TeamService(DataContext dataContext,IMapper mapper)
    {
      this.dataContext = dataContext;
      this.mapper = mapper;
    }
    public async Task<GeneralServiceResponseDto> AddTeamMember(int teamId, string username)
    {
      string assignee = await dataContext.Users
                                    .Where(x => x.UserName == username)
                                    .Select(x => x.UserName)
                                    .FirstOrDefaultAsync();
      if (assignee == null)
      {
        return ResponseHelper.CreateResponse(false, 400, "Username not Found");
      }
      var newTeamMember = new TeamMemberDto
      {
        teamId = teamId,
        username = username
      };
      var teamMemberDto = mapper.Map<TeamMember>(newTeamMember);
      dataContext.TeamMembers.Add(teamMemberDto);
      await dataContext.SaveChangesAsync();
      return ResponseHelper.CreateResponse(true, 200, "Member Added Successfully");
    }

    public Task<GeneralServiceResponseDto> RemoveTeamMember(int teamId, string username)
    {
      throw new NotImplementedException();
    }

    public Task<GeneralServiceResponseDto> UpdateTeamMember(int teamId, string username)
    {
      throw new NotImplementedException();
    }
  }
}