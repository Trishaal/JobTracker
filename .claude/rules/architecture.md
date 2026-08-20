# Architecture Rules

Use a pragmatic Clean Architecture approach.

## Projects

The backend should contain:

- JobTracker.Domain
- JobTracker.Application
- JobTracker.Infrastructure
- JobTracker.Api

## Responsibilities

### Domain

Contains:

- Entities
- Enums
- Domain rules
- Value objects where genuinely useful

The Domain project must not depend on:

- ASP.NET Core
- Entity Framework Core
- AWS SDKs
- Infrastructure
- API

### Application

Contains:

- Application services
- Use cases
- Interfaces required by the application
- DTOs
- Validation
- Application-level business logic

Application may depend on Domain.

### Infrastructure

Contains:

- Entity Framework Core
- PostgreSQL implementation
- External services
- AWS integrations
- Gemini implementation
- Repository implementations only where repositories provide value

Infrastructure may depend on Application and Domain.

### API

Contains:

- Controllers or endpoints
- Authentication configuration
- Dependency injection
- HTTP concerns
- API configuration

Controllers must remain thin.

Business logic must not be implemented directly inside controllers.

## Simplicity

Do not introduce:

- MediatR
- CQRS
- Generic repositories
- Generic services
- Factories
- Specifications
- Event buses

unless the existing project already uses them or the feature clearly benefits from them.

Prefer straightforward application services.