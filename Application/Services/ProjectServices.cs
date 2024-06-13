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
      var projects =  (from project in dataContext.Projects
                            join client in dataContext.Clients on project.ClientId equals client.Id
                            join team in dataContext.Teams on project.TeamId equals team.Id
                            select new ProjectDto
                            {
                              ProjectName = project.ProjectName,
                              Description = project.Description,
                              StartDate = project.StartDate,
                              EndDate = project.EndDate,
                              ClientName = client.ClientName,
                              TeamName = team.TeamName
                            }).ToList();
      return projects;
    }
  }
}