using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobTracker.Application.DTOs;
using JobTracker.Application.Services;

namespace JobTracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobApplicationsController : ControllerBase
    {
        private readonly IJobApplicationService _jobApplicationService;

        public JobApplicationsController(IJobApplicationService jobApplicationService)
        {
            _jobApplicationService = jobApplicationService;
        }

        // GET: api/jobapplications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobApplicationDto>>> GetJobApplications()
        {
            var applications = await _jobApplicationService.GetAllJobApplicationsAsync();
            return Ok(applications);
        }

        // GET: api/jobapplications/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<JobApplicationDto>> GetJobApplication(Guid id)
        {
            var application = await _jobApplicationService.GetJobApplicationByIdAsync(id);

            if (application == null)
            {
                return NotFound();
            }

            return Ok(application);
        }

        // POST: api/jobapplications
        [HttpPost]
        public async Task<ActionResult<JobApplicationDto>> CreateJobApplication(CreateJobApplicationDto createDto)
        {
            try
            {
                var createdApplication = await _jobApplicationService.CreateJobApplicationAsync(createDto);
                return CreatedAtAction(nameof(GetJobApplication), new { id = createdApplication.Id }, createdApplication);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/jobapplications/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJobApplication(Guid id, UpdateJobApplicationDto updateDto)
        {
            if (id != updateDto.Id)
            {
                return BadRequest("ID mismatch");
            }

            var updatedApplication = await _jobApplicationService.UpdateJobApplicationAsync(id, updateDto);

            if (updatedApplication == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/jobapplications/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobApplication(Guid id)
        {
            var result = await _jobApplicationService.DeleteJobApplicationAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
