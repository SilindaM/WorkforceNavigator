namespace Application.Interfaces
{
  using Domain.Dtos.General;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public interface ITeamInterface
  {
    Task<GeneralServiceResponseDto> AddTeamMember(int teamId, string username);
    Task<GeneralServiceResponseDto> RemoveTeamMember(int teamId, string username);
    Task<GeneralServiceResponseDto> UpdateTeamMember(int teamId, string username);
  }
}