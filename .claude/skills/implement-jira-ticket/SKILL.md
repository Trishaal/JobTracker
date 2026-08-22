# Implement Jira Ticket

Use this workflow when implementing a Jira ticket.

## Step 1: Retrieve Requirements

Read the requested Jira ticket.

Extract:

- Summary.
- Description.
- Acceptance criteria.
- Explicit technical requirements.

Do not retrieve unrelated Jira content.

## Step 2: Check Relevant Documentation

Before inspecting the code, determine whether the Jira ticket relates to existing documented behaviour.

Examples:

- Architecture changes -> read Architecture documentation.
- Database changes -> read Database Design documentation.
- Authentication changes -> read Authentication documentation.
- AWS changes -> read Infrastructure documentation.
- CV scoring changes -> read AI CV Scoring documentation.
- CI/CD changes -> read CI/CD documentation.

Retrieve only the documentation relevant to the ticket.

Do not read the entire GitHub Wiki.

## Step 3: Inspect Repository

Identify:

- Relevant backend projects.
- Relevant frontend components.
- Existing tests.
- Existing patterns.

Read only relevant files.

## Step 3: Plan

Create a short implementation plan internally.

Avoid changing unrelated architecture.

## Step 4: Implement

Implement the smallest complete solution.

Maintain:

- Clean Architecture.
- SOLID principles.
- Existing project conventions.
- Backward compatibility where relevant.

## Step 5: Test

Run relevant:

- Backend build.
- Unit tests.
- Integration tests.
- Frontend linting.
- Frontend tests.
- Playwright tests.

## Step 6: Review

Review the diff for:

- Unrelated changes.
- Missing tests.
- Security issues.
- Configuration problems.

## Step 7: Complete

Summarize:

- What changed.
- Files changed.
- Tests run.
- Any limitations or assumptions.

## Documentation Update

## Documentation

Before completing the implementation:

1. Determine whether the feature introduces or changes documented behaviour.
2. Check whether the relevant GitHub Wiki page exists.
3. Create the page if it does not exist.
4. Update the page if it already exists.
5. Document the actual implementation, not the original plan.
6. Do not expose secrets, credentials, API keys, or sensitive configuration.

For a new feature, documentation should include:

- Purpose.
- User-facing behaviour.
- Technical implementation.
- Configuration.
- Testing approach where relevant.
- Limitations or assumptions.

Update the README only when the project's setup, prerequisites, or high-level usage changes.