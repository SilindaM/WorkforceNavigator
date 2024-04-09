using Domain.Dtos.JobTitles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
  public interface IJobTitleService
    {
        Task<List<JobTitleDto>> GetAllJobTitles();
        Task<JobTitleDto> GetJobTitleById(int id);
        Task<JobTitleDto> CreateJobTitle(JobTitleDto jobTitleDto);
        Task<JobTitleDto> UpdateJobTitle(int id, JobTitleDto jobTitleDto);
        Task<JobTitleDto> SoftDeleteJobTitleById(int id);
        Task<JobTitleDto> JobTitleExists(int id);
    }
}