namespace Application.Interfaces
{
  using Domain.Dtos.General;
  using Domain.Dtos.GeneralAdmin;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public interface ITeamInterface
  {
    Task<GeneralServiceResponseDto> UpdateTeamMembership(string username, int? teamId = null);

    Task<IEnumerable<TeamMemberDetailsDto>> GetAllTeamsWithMembersAsync();
  }
}