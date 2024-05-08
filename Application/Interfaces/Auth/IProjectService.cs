using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dtos.Account;
using Domain.Enties;

namespace Application.Interfaces.Auth
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetProjects();
    }
}