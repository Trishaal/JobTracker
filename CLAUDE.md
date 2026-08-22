# JobTracker

## Project Purpose

JobTracker is a personal job application tracking application.

The application allows users to:

- Track job applications.
- Add and edit job details in a table-based interface.
- Track the current status of an application.
- Record the date and time of every status change.
- Generate reports based on application history and status changes.
- Store job descriptions.
- Upload a CV.
- Score a CV against a job description using Google Gemini.
- Authenticate users using AWS Cognito.

The application should remain simple and maintainable. Do not introduce unnecessary architectural patterns, abstractions, services, libraries, or infrastructure.

## Technology Stack

### Backend

- C#
- ASP.NET Core
- .NET
- Entity Framework Core
- PostgreSQL
- REST API
- AWS Cognito for authentication

### Frontend

- React 19
- TypeScript
- Vite
- Tailwind CSS
- shadcn/ui

### Testing

- Unit tests for backend business logic.
- Integration tests for API and database behaviour.
- Playwright for end-to-end frontend tests.

### Infrastructure

- AWS Free Tier where practical.
- PostgreSQL hosted using AWS infrastructure where appropriate.
- Terraform for infrastructure as code.
- GitHub Actions for CI.
- GitHub repository variables and secrets for environment-specific configuration.

## Architecture

Use Clean Architecture, but keep the implementation pragmatic.

Preferred structure:

- Domain
- Application
- Infrastructure
- API

Dependency direction:

API -> Application
Infrastructure -> Application
Application -> Domain

The Domain project must not depend on Infrastructure or API.

Do not introduce CQRS, MediatR, repositories, factories, specifications, or other patterns unless they provide a clear benefit for the current feature.

Prefer simple, understandable code.

## SOLID Principles

Follow SOLID principles pragmatically.

Do not create abstractions for code that has only one simple use case unless there is a clear reason.

Prefer existing project patterns over introducing new patterns.

## Core Domain

The primary entity is a Job Application.

A job application includes:

- Company
- Job Title
- Location
- Date Applied
- Source
- Source Link
- Status
- Salary Range
- Next Action
- Notes
- Job Description

Date Applied should default to the current date when creating a new application.

Job Source values include:

- Seek
- Indeed
- LinkedIn
- Other

Job Status values should support the application's recruitment workflow, including:

- Applied
- Phone Screen
- Technical Test
- Interview
- Offer
- Rejected
- Withdrawn

Use enums or another strongly typed approach where appropriate.

## Status History

Every job application status change must create an immutable status history record.

The status history must record:

- Job Application ID
- Previous Status
- New Status
- Changed At date and time

Status changes must not overwrite historical status information.

The history will be used for reporting and analytics.

## User Interface

The main job application screen should provide:

- A table-based view of applications.
- Inline editing where appropriate.
- Ability to add a new job application.
- Ability to edit an existing application.
- A simple and clear user experience.

Do not overcomplicate the UI.

Follow existing frontend patterns and shadcn/ui conventions.

## CV Scoring

The application must support:

1. Uploading a CV.
2. Selecting or providing a job description.
3. Sending the relevant information to the configured Gemini integration.
4. Receiving a structured CV score and feedback.

The Gemini configuration must not be hard-coded.

Configuration must come from environment-specific configuration.

Secrets and API keys must never be committed to the repository.

The AI provider should be isolated behind a simple application interface so the implementation can be changed later.

Do not expose API keys to the frontend.

## Configuration

Follow the ASP.NET Core configuration hierarchy.

Use:

- appsettings.json for non-secret defaults.
- appsettings.Development.json for local development defaults where appropriate.
- Environment variables for deployment configuration.
- GitHub Secrets for sensitive CI/CD values.
- GitHub Variables for non-sensitive environment-specific values.

Do not hard-code:

- Connection strings
- API keys
- AWS credentials
- Cognito secrets
- Environment URLs
- Infrastructure identifiers that differ between environments

Provide example configuration files where useful.

## Authentication

Use AWS Cognito.

The backend must validate authentication tokens.

Do not trust authentication information provided directly by the frontend.

Authorization must be enforced by the backend.

## Testing Requirements

Every feature must be considered for:

- Unit tests.
- Integration tests.
- Frontend Playwright tests where user behaviour changes.

Prioritize meaningful coverage over artificial coverage.

Test:

- Business rules.
- Status change history.
- Validation.
- Error cases.
- API behaviour.
- Authentication and authorization where practical.
- Important user workflows.

Do not write meaningless tests purely to increase coverage numbers.

## Git Workflow

Before making changes:

1. Check the current branch.
2. Check the working tree status.
3. Do not overwrite unrelated user changes.
4. Read only the files necessary to understand the requested change.

When merging or pulling:

1. Perform the requested Git operation.
2. Investigate conflicts only if they occur.
3. Read only files involved in conflicts or validation failures.
4. Run relevant validation after resolving conflicts.

## Jira Workflow

When working from a Jira ticket:

1. Read the requested ticket first.
2. Identify the requirements and acceptance criteria.
3. Do not automatically retrieve every comment, linked issue, epic, or attachment.
4. Retrieve additional Jira information only when required.
5. Inspect only relevant application code.
6. Implement the smallest complete solution that satisfies the requirements.

## Pull Requests

Pull request titles must follow Conventional Commits.

Examples:

- feat: add job application status history
- fix: record timestamp when application status changes
- test: add integration tests for job applications
- docs: update local development instructions

Do not create unrelated changes in a pull request.

## Validation

Before considering work complete:

1. Build the affected backend projects.
2. Run relevant unit tests.
3. Run relevant integration tests.
4. Run frontend linting where frontend code changed.
5. Run frontend tests where relevant.
6. Run Playwright tests for affected user workflows where practical.
7. Check for formatting or style issues.
8. Summarize changed files.
9. Report any tests that could not be run.

## Project Documentation

Detailed project documentation is maintained in the GitHub Wiki.

Do not load or read all project documentation by default.

Read only the documentation relevant to the current task.

### Documentation Locations

Use the following documentation when required:

| Topic | Documentation |
|---|---|
| Project architecture | GitHub Wiki: Architecture |
| Domain and business rules | GitHub Wiki: Domain Model |
| Database design | GitHub Wiki: Database Design |
| Authentication | GitHub Wiki: Authentication |
| AWS infrastructure | GitHub Wiki: Infrastructure |
| Terraform | GitHub Wiki: Infrastructure |
| CV scoring and Gemini integration | GitHub Wiki: AI CV Scoring |
| Local development setup | GitHub Wiki: Local Development |
| Testing strategy | GitHub Wiki: Testing |
| CI/CD and GitHub Actions | GitHub Wiki: CI/CD |
| Project setup decisions | GitHub Wiki: Architecture Decisions |
| Application features | GitHub Wiki: Features |

### Documentation Rules

Before implementing a feature:

1. Read the relevant Jira ticket if one was provided.
2. Identify which project documentation is relevant.
3. Read only the relevant documentation.
4. Do not retrieve the entire GitHub Wiki.
5. Do not read unrelated documentation.

When architecture, infrastructure, configuration, or application behaviour changes:

1. Identify whether existing documentation is affected.
2. Update the relevant GitHub Wiki page.
3. Do not create duplicate documentation unless required.

The README should contain only high-level project information and instructions required to run the application.

Detailed technical documentation belongs in the GitHub Wiki.

## Project Documentation

Project documentation must be maintained in the GitHub Wiki.

The GitHub Wiki may initially be empty. Claude is responsible for creating and maintaining relevant project documentation as the application is developed.

Do not create all possible documentation pages before they are needed.

Create documentation when a feature, architecture decision, configuration, infrastructure component, or workflow is implemented.

### Initial Wiki Structure

Create and maintain the following Wiki pages as relevant:

- Home
- Project Overview
- Features
- Architecture
- Domain Model
- Database Design
- Authentication
- AI CV Scoring
- Infrastructure
- Local Development
- Testing
- CI/CD
- Configuration
- Architecture Decisions

### Documentation Creation Rules

When implementing the first relevant feature or component, create the corresponding Wiki documentation if it does not already exist.

Examples:

- When the backend architecture is established, create or update the Architecture page.
- When Job Applications and Status History are implemented, create or update Domain Model and Database Design.
- When AWS Cognito is configured, create or update Authentication.
- When Gemini CV scoring is implemented, create or update AI CV Scoring.
- When Terraform infrastructure is implemented, create or update Infrastructure.
- When local setup is established, create or update Local Development.
- When unit, integration, or Playwright testing is configured, create or update Testing.
- When GitHub Actions are configured, create or update CI/CD.
- When configuration variables or environment configuration are introduced, create or update Configuration.
- When an important technical decision is made, document it under Architecture Decisions.

### Documentation Content

Documentation must describe the actual implemented solution.

Do not document planned, assumed, or unimplemented functionality as if it already exists.

Before creating or updating documentation:

1. Inspect the actual implementation.
2. Use the implementation as the source of truth.
3. Document configuration without exposing secrets.
4. Include setup and usage instructions where relevant.
5. Keep documentation concise and practical.

### Documentation Updates

When completing a feature or significant change:

1. Check whether relevant Wiki documentation exists.
2. Create the documentation page if it does not exist.
3. Update the page if the implementation changed.
4. Do not update unrelated documentation.

Documentation should explain:

- What the feature does.
- How it is structured.
- How it is configured.
- How to run or use it where applicable.
- Important technical decisions.
- Relevant limitations or assumptions.

### README

The repository README should remain concise.

The README should include:

- Project overview.
- Technology stack.
- Prerequisites.
- Quick local setup.
- How to run the backend.
- How to run the frontend.
- How to run tests.
- Link to the GitHub Wiki.

Detailed technical documentation belongs in the GitHub Wiki.

## Feature Roadmap and Progress

The GitHub Wiki page named `Features` is the source of truth for feature implementation progress.

The Features page contains:

- The ordered feature roadmap.
- Feature status.
- The current next feature.
- Concise completion notes.

When asked to:

- implement the next feature
- continue development
- work on the next task
- continue the project

Claude must:

1. Read only the GitHub Wiki `Features` page.
2. Identify the `Current Next Feature`.
3. Implement only that feature.
4. Do not skip ahead unless explicitly instructed.
5. Add or update relevant tests.
6. Run relevant validation.
7. Mark the completed feature as complete in the GitHub Wiki.
8. Update `Current Next Feature`.
9. Create or update other relevant GitHub Wiki documentation if required.

Do not scan the entire repository or GitHub Wiki to determine what feature should be implemented.

Do not implement multiple roadmap features unless explicitly requested.