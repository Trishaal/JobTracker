---
paths:
  - "src/**/*.cs"
---

# Backend Rules

## C#

- Use modern C# features supported by the project.
- Use nullable reference types correctly.
- Prefer clear and descriptive names.
- Avoid unnecessary comments that merely describe obvious code.
- Avoid static global state.
- Prefer dependency injection.

## Async

- Use async/await for I/O operations.
- Do not use `.Result` or `.Wait()`.
- Accept CancellationToken for asynchronous operations where appropriate.
- Pass CancellationToken to downstream operations.

## API

- Validate incoming requests.
- Return appropriate HTTP status codes.
- Use consistent error responses.
- Do not expose internal exception details.
- Keep controllers thin.

## Entity Framework

- Use async database operations.
- Use AsNoTracking for read-only queries where appropriate.
- Avoid N+1 queries.
- Do not load unnecessary data.
- Filter and paginate at the database level where appropriate.

## Date and Time

All status history timestamps must use a consistent time standard.

Prefer UTC for persisted timestamps unless the domain explicitly requires another approach.

The frontend may convert timestamps for display.