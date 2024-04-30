namespace WorkForceNavigator.Tests.Controllers
{
  using API.Controllers.GeneralAdmin;
  using Application.Interfaces.GenericInterfaces;
  using Application.Services.GenericServices;
  using AutoMapper;
  using Domain.Dtos.Departments;
  using Domain.Enties;
  using FakeItEasy;
  using FluentAssertions;
  using FluentAssertions.Execution;
  using Microsoft.AspNetCore.Mvc;
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using Xunit;

  public class DepartmentControllerTests
  {
    private readonly IGenericService<Department, DepartmentDto> genericService;
  //  private readonly IMapper mapper;

    public DepartmentControllerTests()
    {
      genericService = A.Fake<IGenericService<Department, DepartmentDto>>();
     // mapper = A.Fake<IMapper>();
    }

    [Fact]
    public async void DepartmentController_GetDepartments_ReturnOk()
    {
      //Arrange
      var departments = A.Fake<ICollection<DepartmentDto>>();
      var departmentList = A.Fake<List<DepartmentDto>>();
      var controller = new DepartmentController(genericService);
      
      //Act
      var result =await controller.GetAllDepartments();

      // Assert
      result.Should().NotBeNull();
      result.Should().BeOfType(typeof(OkObjectResult));
    }
    [Fact]
    public async void DepartmenController_CreateDepartment_ReturnOk()
    {
      // Arrange
      int departmentId = 1;
      var departmentCreate = A.Fake<DepartmentDto>();
      departmentCreate.DepartmentName = "TestDepartment"; // Set a name for the department to be created
      var departmentList = new List<DepartmentDto>
    {
        new DepartmentDto { DepartmentName = "TestDepartment" } // Create a department with the same name as departmentCreate
    };

      // Setup the fake service to return the populated list
      A.CallTo(() => genericService.GetAllAsync())
          .Returns(Task.FromResult<IEnumerable<DepartmentDto>>(departmentList));

      var controller = new DepartmentController(genericService);

      // Act
     await controller.CreateDepartment(departmentCreate);

      //Assert
      A.CallTo(() => genericService.CreateAsync(departmentCreate)).MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async void DepartmentController_UpdateDepartment_Return()
    {
      //Arrange
      var departmentUpdate = A.Fake<DepartmentDto>();
      departmentUpdate.Description = "Testing";
      departmentUpdate.DepartmentName = "Testing Name";
      departmentUpdate.Id = 4;
      var controller = new DepartmentController(genericService);  

      //Act
      var result = await controller.UpdateDepartment(departmentUpdate.Id,departmentUpdate);

      //Assert
      A.CallTo(() => genericService.UpdateAsync(departmentUpdate.Id, departmentUpdate)).MustHaveHappenedOnceExactly(); 
    }
    [Fact]
    public async void DepartmentController_GetById_ReturnOk()
    {
      //Arrange
      var departmentById = A.Fake<DepartmentDto>();
      departmentById.Id = 4;
      var controller = new DepartmentController(genericService);

      //Act
      var result = await controller.GetDepartmentById(departmentById.Id); 

      //Assert
      A.CallTo(()=> genericService.GetByIdAsync(departmentById.Id)).MustHaveHappenedOnceExactly();
    }
    [Fact]
    public async void DepartmentController_SoftDelete_ReturnOK()
    {
      //Arrange
      var departmentSoftDelete = A.Fake<DepartmentDto>();
      departmentSoftDelete.Id = 4;
      var controller = new DepartmentController(genericService);
      //Act
      var result = await controller.SoftDeleteDepartment(departmentSoftDelete.Id);
      //Assert
      A.CallTo(() => genericService.SoftDelete(departmentSoftDelete.Id));
    }
    [Fact]
    public async void DepartmentController_UnSoftDelete_ReturnOK()
    {
      //Arrange
      var departmentSoftDelete = A.Fake<DepartmentDto>();
      departmentSoftDelete.Id = 4;
      var controller = new DepartmentController(genericService);
      //Act
      var result = await controller.SoftDeleteDepartment(departmentSoftDelete.Id);
      //Assert
      A.CallTo(() => genericService.UndoSoftDeleteAsync(departmentSoftDelete.Id));
    }
  }
}