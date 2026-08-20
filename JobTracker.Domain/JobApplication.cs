using System;

namespace JobTracker.Domain
{
    /// <summary>
    /// Represents a job application entity.
    /// </summary>
    public class JobApplication
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

    /// <summary>
    /// Enum for job source values.
    /// </summary>
    public enum JobSource
    {
        Seek,
        Indeed,
        LinkedIn,
        Other
    }

    /// <summary>
    /// Enum for job status values.
    /// </summary>
    public enum JobStatus
    {
        Applied,
        PhoneScreen,
        TechnicalTest,
        Interview,
        Offer,
        Rejected,
        Withdrawn
    }
}