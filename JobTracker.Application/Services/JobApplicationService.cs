using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTracker.Application.DTOs;
using JobTracker.Domain;
using JobTracker.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Application.Services
{
    public interface IJobApplicationService
    {
        Task<IEnumerable<JobApplicationDto>> GetAllJobApplicationsAsync();
        Task<JobApplicationDto?> GetJobApplicationByIdAsync(Guid id);
        Task<JobApplicationDto> CreateJobApplicationAsync(CreateJobApplicationDto createDto);
        Task<JobApplicationDto?> UpdateJobApplicationAsync(Guid id, UpdateJobApplicationDto updateDto);
        Task<bool> DeleteJobApplicationAsync(Guid id);
    }

    public class JobApplicationService : IJobApplicationService
    {
        private readonly JobTrackerDbContext _context;

        public JobApplicationService(JobTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobApplicationDto>> GetAllJobApplicationsAsync()
        {
            var applications = await _context.JobApplications
                .AsNoTracking()
                .ToListAsync();

            return applications.Select(a => new JobApplicationDto
            {
                Id = a.Id,
                Company = a.Company,
                JobTitle = a.JobTitle,
                Location = a.Location,
                DateApplied = a.DateApplied,
                Source = a.Source,
                SourceLink = a.SourceLink,
                Status = a.Status,
                SalaryRange = a.SalaryRange,
                NextAction = a.NextAction,
                Notes = a.Notes,
                JobDescription = a.JobDescription,
                CreatedAt = a.CreatedAt,
                UpdatedAt = a.UpdatedAt
            });
        }

        public async Task<JobApplicationDto?> GetJobApplicationByIdAsync(Guid id)
        {
            var application = await _context.JobApplications
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);

            if (application == null)
                return null;

            return new JobApplicationDto
            {
                Id = application.Id,
                Company = application.Company,
                JobTitle = application.JobTitle,
                Location = application.Location,
                DateApplied = application.DateApplied,
                Source = application.Source,
                SourceLink = application.SourceLink,
                Status = application.Status,
                SalaryRange = application.SalaryRange,
                NextAction = application.NextAction,
                Notes = application.Notes,
                JobDescription = application.JobDescription,
                CreatedAt = application.CreatedAt,
                UpdatedAt = application.UpdatedAt
            };
        }

        public async Task<JobApplicationDto> CreateJobApplicationAsync(CreateJobApplicationDto createDto)
        {
            var application = new JobApplication
            {
                Id = Guid.NewGuid(),
                Company = createDto.Company,
                JobTitle = createDto.JobTitle,
                Location = createDto.Location,
                DateApplied = createDto.DateApplied,
                Source = createDto.Source,
                SourceLink = createDto.SourceLink,
                Status = createDto.Status,
                SalaryRange = createDto.SalaryRange,
                NextAction = createDto.NextAction,
                Notes = createDto.Notes,
                JobDescription = createDto.JobDescription,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.JobApplications.Add(application);
            await _context.SaveChangesAsync();

            return new JobApplicationDto
            {
                Id = application.Id,
                Company = application.Company,
                JobTitle = application.JobTitle,
                Location = application.Location,
                DateApplied = application.DateApplied,
                Source = application.Source,
                SourceLink = application.SourceLink,
                Status = application.Status,
                SalaryRange = application.SalaryRange,
                NextAction = application.NextAction,
                Notes = application.Notes,
                JobDescription = application.JobDescription,
                CreatedAt = application.CreatedAt,
                UpdatedAt = application.UpdatedAt
            };
        }

        public async Task<JobApplicationDto?> UpdateJobApplicationAsync(Guid id, UpdateJobApplicationDto updateDto)
        {
            if (id != updateDto.Id)
                return null;

            var application = await _context.JobApplications.FindAsync(id);
            if (application == null)
                return null;

            application.Company = updateDto.Company;
            application.JobTitle = updateDto.JobTitle;
            application.Location = updateDto.Location;
            application.DateApplied = updateDto.DateApplied;
            application.Source = updateDto.Source;
            application.SourceLink = updateDto.SourceLink;
            application.Status = updateDto.Status;
            application.SalaryRange = updateDto.SalaryRange;
            application.NextAction = updateDto.NextAction;
            application.Notes = updateDto.Notes;
            application.JobDescription = updateDto.JobDescription;
            application.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return new JobApplicationDto
            {
                Id = application.Id,
                Company = application.Company,
                JobTitle = application.JobTitle,
                Location = application.Location,
                DateApplied = application.DateApplied,
                Source = application.Source,
                SourceLink = application.SourceLink,
                Status = application.Status,
                SalaryRange = application.SalaryRange,
                NextAction = application.NextAction,
                Notes = application.Notes,
                JobDescription = application.JobDescription,
                CreatedAt = application.CreatedAt,
                UpdatedAt = application.UpdatedAt
            };
        }

        public async Task<bool> DeleteJobApplicationAsync(Guid id)
        {
            var application = await _context.JobApplications.FindAsync(id);
            if (application == null)
                return false;

            _context.JobApplications.Remove(application);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
