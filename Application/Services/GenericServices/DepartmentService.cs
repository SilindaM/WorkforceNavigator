namespace Application.Services.GenericServices
{
  using Application.Interfaces.GenericInterfaces;
  using Domain.Dtos.GeneralAdmin;
  using Persistence;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class DepartmentService : IDepartmentService
  {
    private readonly DataContext dataContext;

    public DepartmentService(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }

    public async Task<IEnumerable<UserDetailJobTitle>> GetUserJobTitleTeamsListAsync(int id)
    {
      var details = (from u in dataContext.Users
                     join j in dataContext.JobTitles on u.JobTitleId equals j.Id
                     join d in dataContext.Departments on j.DepartmentId equals d.Id
                     join t in dataContext.Teams on u.TeamId equals t.Id
                     where d.Id == id
                     select new UserDetailJobTitle
                     {
                       FirstName = u.FirstName,
                       LastName = u.LastName,
                       Email = u.Email,
                       JobTitle = j.Title,
                       Team = t.TeamName,
                     }).ToList();
      return details;
    }
  }
}