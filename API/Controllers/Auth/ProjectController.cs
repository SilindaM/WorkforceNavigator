
namespace API.Controllers.Auth
{
  using Application.Interfaces;

  using Application.Interfaces.GenericInterfaces;
  using Application.Services.Auth;
  using Application.Services.GenericServices;
  using Domain.Dtos.Account;
  using Domain.Dtos.GeneralAdmin;
  using Domain.Enties;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
    private readonly IProjectService projectService;
    private readonly IGenericService<Project, CreateProjectDto> genericService;

    public ProjectController(IProjectService projectService,IGenericService<Project,CreateProjectDto> genericService)
        {
      this.projectService = projectService;
      this.projectService = projectService;
      this.genericService = genericService;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProjectDto>>> GetProjects()
    {
      try
      {
        var projects = await projectService.GetAllProjectsWithClientsAsync();
        return Ok(projects);
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"An error occurred while retrieving projects: {ex.Message}");
      }
    }
    [HttpPost]
    public async Task<IActionResult> CreateNewProject([FromBody] CreateProjectDto projectDto)
    {
      var result = await genericService.CreateAsync(projectDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }
  }
}