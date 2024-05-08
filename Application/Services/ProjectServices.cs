namespace Application.Services.GenericServices
{
  using Application.Interfaces;
  using Application.Interfaces.GenericInterfaces;
  using Domain.Dtos.GeneralAdmin;
  using Domain.Enties;
  using Microsoft.EntityFrameworkCore;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class ProjectService : IProjectService
  {
    private readonly DataContext dataContext;

    public ProjectService(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }
    public async Task<IEnumerable<ProjectDto>> GetAllProjectsWithClientsAsync()
    {
      var projects =  dataContext.Projects
          .Join(dataContext.Clients, // Join projects with clients
              project => project.ClientId,
              client => client.Id,
              (project, client) => new ProjectDto
              {
                ProjectName = project.ProjectName,
                Description = project.Description,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                ClientName = client.ClientName // Select ClientName from the join
              })
          .ToList();

      return projects;
    }

  }
}
