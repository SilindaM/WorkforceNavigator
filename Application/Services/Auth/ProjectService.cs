using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Auth;
using AutoMapper;
using Domain.Dtos.Account;
using Domain.Enties;
using Persistence;

namespace Application.Services.Auth
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public ProjectService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Project>> GetProjects()
        {
            return await _dataContext.Projects.ToListAsync();
        }
    }
}