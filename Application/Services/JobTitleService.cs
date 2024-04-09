using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;
using AutoMapper;
using Domain.Dtos.JobTitles;
using Domain.Enties;
using Microsoft.EntityFrameworkCore; // Add this for EF Core
using Persistence;

namespace Application.Services
{
  public class JobTitleService : IJobTitleService
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public JobTitleService(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async  Task<JobTitleDto> CreateJobTitle(JobTitleDto jobTitleDto)
        {
            // Check if the job title already exists
            if (dataContext.JobTitles.Any(x => x.Title == jobTitleDto.Title))
            {
                throw new ArgumentNullException($"Job Title {jobTitleDto.Title} already exists.");
            }

            // Query department by name to get department from jobTitleDto, then use its id to insert in jobtitle
            var departmentId = dataContext.Departments
                .Where(x => x.DepartmentName == jobTitleDto.DepartmentName)
                .Select(c => c.Id)
                .FirstOrDefault();

            // Verify if the departmentId exists for the DepartmentName
            if (departmentId == 0)
            {
                   throw new ArgumentNullException($"Department {jobTitleDto.DepartmentName} doesn't exist.");
            }

            // Convert DTO to Entity, perform any necessary business logic, and save
            var jobTitle = new JobTitle
            {
                Title = jobTitleDto.Title,
                IsDeleted = false,
                DepartmentId = departmentId
            };

            // Save to the database
            dataContext.JobTitles.Add(jobTitle);
            dataContext.SaveChanges();

            return (mapper.Map<JobTitleDto>(jobTitle));
        }

        public async  Task<JobTitleDto> GetJobTitleById(int id)
        {
            // Check if the job title exists
            var jobTitle = dataContext.JobTitles.Find(id);

            if (jobTitle == null)
            {
                throw new ArgumentNullException($"Job Title {id} doesn't exist.");
            }

            // Now you have the actual JobTitle object
            return (mapper.Map<JobTitleDto>(jobTitle));
        }

        public async Task<List<JobTitleDto>> GetAllJobTitles()
        {
            // Get job titles which are not deleted
            var jobTitles = await dataContext.JobTitles.ToListAsync();

            // Check if the list is empty
            if (jobTitles.Count != 0)
            {
                return (mapper.Map<List<JobTitleDto>>(jobTitles));
            }
             throw new ArgumentNullException($"JobTitles are empty.");
        }

        public async Task<JobTitleDto> UpdateJobTitle(int id, JobTitleDto jobTitleDto)
        {
            // Get the job title by id
            var jobTitle = await dataContext.JobTitles.FindAsync(id);

            // Check if the job title exists
            if (jobTitle == null)
            {
                throw new ArgumentNullException($"JobTitle with id {id} doesn't exist.");
            }

            // Check if the new JobTitle Name doesn't exist
            var existingJobTitle = dataContext.JobTitles.FirstOrDefault(x => x.Title == jobTitleDto.Title && x.Id != id);

            if (existingJobTitle != null)
            {
                throw new ArgumentNullException($"JobTitle with name {jobTitleDto.Title} already exists.");
            }

            // Update jobTitle with the new values
            mapper.Map(jobTitleDto, jobTitle);

            // Save changes to the database
            dataContext.SaveChanges();

            return (mapper.Map<JobTitleDto>(jobTitle));
        }

        public async Task<JobTitleDto> SoftDeleteJobTitleById(int id)
        {
            // Check if the job title exists
            var jobTitle = dataContext.JobTitles.Find(id);

            if (jobTitle == null)
            {
                throw new ArgumentNullException($"Job Title {id} doesn't exist.");
            }

            // Set IsDeleted to true
            jobTitle.IsDeleted = true;

            // Save changes to the data context
            dataContext.SaveChanges();

            return (mapper.Map<JobTitleDto>(jobTitle));
        }
      

        public async Task<JobTitleDto> JobTitleExists(int id)
        {
            // Check if the job title exists
            var jobTitle =  dataContext.JobTitles.FindAsync(id);

            if (jobTitle == null)
            {
                throw new ArgumentNullException($"Job Title {id} doesn't exist.");
            }

            return  (mapper.Map<JobTitleDto>(jobTitle));
        }

    }
}
