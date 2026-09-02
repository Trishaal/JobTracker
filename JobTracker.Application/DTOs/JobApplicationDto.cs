using System;
using JobTracker.Domain;

namespace JobTracker.Application.DTOs
{
    public class JobApplicationDto
    {
        public Guid Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime DateApplied { get; set; }
        public JobSource Source { get; set; }
        public string SourceLink { get; set; } = string.Empty;
        public JobStatus Status { get; set; }
        public string? SalaryRange { get; set; }
        public string? NextAction { get; set; }
        public string? Notes { get; set; }
        public string? JobDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class CreateJobApplicationDto
    {
        public string Company { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime DateApplied { get; set; }
        public JobSource Source { get; set; }
        public string SourceLink { get; set; } = string.Empty;
        public JobStatus Status { get; set; }
        public string? SalaryRange { get; set; }
        public string? NextAction { get; set; }
        public string? Notes { get; set; }
        public string? JobDescription { get; set; }
    }

    public class UpdateJobApplicationDto
    {
        public Guid Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime DateApplied { get; set; }
        public JobSource Source { get; set; }
        public string SourceLink { get; set; } = string.Empty;
        public JobStatus Status { get; set; }
        public string? SalaryRange { get; set; }
        public string? NextAction { get; set; }
        public string? Notes { get; set; }
        public string? JobDescription { get; set; }
    }
}
