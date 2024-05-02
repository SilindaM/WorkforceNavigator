namespace API.Controllers.GeneralAdmin
{
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using Application.Interfaces.GenericInterfaces;
  using Application.Services.Auth;
  using Application.Services.GenericServices;
  using Domain.Dtos.Account;
  using Domain.Dtos.GeneralAdmin;
  using Domain.Enties.TimeSheets;
  using Domain.Entities;
  using FluentResults;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  [Route("api/[controller]")]
  public class TeamController : ControllerBase
  {
    private readonly IGenericService<Team, TeamDto> _teamService;

    public TeamController(
        IGenericService<Team, TeamDto> teamService)
    {
      _teamService = teamService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTeams()
    {
      var result = await _teamService.GetAllAsync();
      return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTeamById(int id)
    {
      var result = await _teamService.GetByIdAsync(id);
      if (result is null)
      {
        return NotFound("Team not found");
      }
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTeam([FromBody] TeamDto teamDto)
    {
      var result = await _teamService.CreateAsync(teamDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTeam(int id, [FromBody] TeamDto updateTeamDto)
    {
      var result = await _teamService.UpdateAsync(id, updateTeamDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> SoftDeleteTeam(int id)
    {
      var result = await _teamService.SoftDelete(id);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpDelete("{id}/undo")]
    public async Task<IActionResult> UnSoftDeleteTeam(int id)
    {
      var result = await _teamService.UndoSoftDeleteAsync(id);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }
  }
}