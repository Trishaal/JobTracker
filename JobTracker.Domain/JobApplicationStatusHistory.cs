using System;

namespace JobTracker.Domain
{
    /// <summary>
    /// Represents an immutable status history record for a job application.
    /// </summary>
    public class JobApplicationStatusHistory
    {
        public Guid Id { get; set; }
        public Guid JobApplicationId { get; set; }
        public JobStatus PreviousStatus { get; set; }
        public JobStatus NewStatus { get; set; }
        public DateTime ChangedAt { get; set; }

        // Navigation property (virtual for EF Core lazy loading)
        public virtual JobApplication JobApplication { get; set; } = null!;
    }
}