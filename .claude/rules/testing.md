# Testing Rules

## Unit Tests

Unit tests should focus on:

- Business rules.
- Validation.
- Status changes.
- Application services.
- Error conditions.

Avoid unnecessary mocking.

Do not mock simple domain objects.

## Integration Tests

Integration tests should verify:

- API endpoints.
- Database persistence.
- Entity Framework mappings.
- Validation.
- Authentication and authorization where practical.
- Status history persistence.

Prefer realistic infrastructure for database integration tests.

## Playwright

Playwright tests should cover important user journeys.

Initial scenarios should include:

- User authentication.
- Viewing job applications.
- Adding a job application.
- Editing a job application.
- Changing a status.
- Verifying the updated application state.
- Uploading a CV.
- Running CV scoring using a controlled test implementation.

Avoid brittle tests based on implementation details.

Prefer accessible selectors.

## Test Changes

When changing production behaviour:

1. Check whether existing tests require updates.
2. Add tests for new behaviour.
3. Test failure paths where meaningful.