using Application.Interfaces.Auth;
using Application.Services.Auth;
using Domain.Dtos.Account;
using Domain.Enties;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects() => (await projectService.GetProjects()).ToList();
  
    }
}