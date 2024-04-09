using FluentResults;
using System;
using System.Collections.Generic;

namespace Application.Services.GenericInterfaces
{

  public interface IGenericService<TEntity, TDto>
     where TEntity : class
     where TDto : class
  {
    Task <Result<TDto>> CreateAsync(TDto entityDto);
    Task<Result<List<TDto>>> GetAllAsync();
    Task <Result<TDto>>UpdateAsync(int id, TDto updatedEntityDto);
    Task<Result<bool>> SoftDelete(int id);
    Task<Result<TDto>> GetByIdAsync(int id);
    // Task<string> GetUserIdAsync(int id);
  }

}
