namespace Application.Interfaces
{
  using Domain.Dtos.GeneralAdmin;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public interface IProjectService
  {
    Task<IEnumerable<ProjectDto>> GetAllProjectsWithClientsAsync();
  }
}
