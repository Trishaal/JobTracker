# JobTracker — Base44 Dev Environment

## What this is

A .NET 5.0 Web API (in-memory database) with a React + Vite + TypeScript frontend.
No external services or credentials are required to run.

## Architecture

- **Backend**: ASP.NET Core 5.0 API at the repo root (`Program.cs`, `Startup.cs`, `Controllers/`).
  Uses Entity Framework Core with an **in-memory database** (`JobTrackerDb`).
  Clean Architecture projects live in subdirectories: `JobTracker.Domain/`, `JobTracker.Application/`, `JobTracker.Infrastructure/`.
- **Frontend**: React 18 + Vite 5 in `frontend/`, served on port 3000.
- **API port**: 5000 inside the container, mapped to host port 8000.

## Fixes applied for sandbox setup

1. **Root `JobTracker.Api.csproj`** had broken `ProjectReference` paths pointing to duplicate
   root-level `.csproj` files that used `..\` (above repo root). Fixed to reference the
   subdirectory projects directly (`JobTracker.Application/JobTracker.Application.csproj`, etc.).
   Added `<Compile Remove>` for subdirectory projects to prevent duplicate compilation.
2. **Deleted root-level duplicate `.csproj` files** (`JobTracker.Application.csproj`,
   `JobTracker.Domain.csproj`, `JobTracker.Infrastructure.csproj`) — they had broken references
   and were not needed.
3. **`Startup.cs`** was missing `using Microsoft.EntityFrameworkCore;` and
   `using JobTracker.Infrastructure;` — added so `UseInMemoryDatabase` and `JobTrackerDbContext` resolve.

## Running

```sh
docker compose -f docker-compose.base44.yml up -d --build
```

- Frontend: http://localhost:3000
- API: http://localhost:8000 (Swagger at /swagger in Development mode)
- API health: GET /weatherforecast

## Notes

- `dotnet watch` with `DOTNET_USE_POLLING_FILE_WATCHER=1` provides live reload on bind mounts.
- `ASPNETCORE_URLS=http://0.0.0.0:5000` overrides launchSettings.json (which has HTTPS URLs).
- `UseHttpsRedirection()` in Startup.cs is a no-op without an HTTPS port configured (logs a warning, does not redirect).
- No secrets needed — the in-memory database requires no credentials, and external integrations
  (Gemini, Cognito) are not yet implemented.
