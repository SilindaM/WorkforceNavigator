namespace API.Controllers.GeneralAdmin
{
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using Application.Interfaces.GenericInterfaces;
  using Application.Services.Auth;
  using Application.Services.GenericServices;
  using AutoMapper;
  using Domain.Dtos.Account;
  using Domain.Dtos.Departments;
  using Domain.Enties;
  using Domain.Enties.Leaves;
  using FluentResults;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  [Route("api/[controller]")]
  public class DepartmentController : ControllerBase
  {
    private readonly IMapper mapper;
    private readonly IGenericService<Department, DepartmentDto> _DepartmentService;
    private readonly IGenericService<Department, UpdateDepartmentDto> updateDepartmentService;

    public DepartmentController(IMapper mapper,
        IGenericService<Department, DepartmentDto> DepartmentService, IGenericService<Department, UpdateDepartmentDto> updateDepartmentService)
    {
      this.mapper = mapper;
      _DepartmentService = DepartmentService;
      this.updateDepartmentService = updateDepartmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllDepartments()
    {
      var result = await _DepartmentService.GetAllAsync();

      return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetDepartmentById(int id)
    {
      var result = await _DepartmentService.GetByIdAsync(id);
      if (result is null)
      {
        return NotFound("leaveRequestId not found");
      }
      else
      {
        return Ok(result);
      }
    }

    [HttpPost("CreateDepartment")]
    public async Task<IActionResult> CreateDepartment([FromBody] DepartmentDto DepartmentDto)
    {
      var result = await _DepartmentService.CreateAsync(DepartmentDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpPost]
    [Route("UpdateDepartment")]
    public async Task<IActionResult> UpdateDepartment(int id, [FromBody] UpdateDepartmentDto updateDepartmentDto)
    {
      var result = await updateDepartmentService.UpdateAsync(id, updateDepartmentDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      else
      {
        return StatusCode(result.StatusCode, result.Message);
      }
    }

    [HttpDelete]
    [Route("DeleteDepartment")]
    public async Task<IActionResult> SoftDeleteDepartment(int id)
    {
      var result = await _DepartmentService.SoftDelete(id);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpDelete("{id}/undo")]
    public async Task<IActionResult> UnSoftDeleteDepartment(int id)
    {
      var result = await _DepartmentService.UndoSoftDeleteAsync(id);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }
    [HttpGet("paged")]
    public async Task<IActionResult> GetPaged(int pageNumber, int pageSize)
    {
      if (pageNumber < 1 || pageSize < 1)
      {
        return BadRequest("Page number and page size must be greater than 0.");
      }

      var departments = await _DepartmentService.GetPagedAsync(pageNumber, pageSize);
      var departmentDtos = mapper.Map<IEnumerable<DepartmentDto>>(departments);

      return Ok(departmentDtos);
    }
  }
}