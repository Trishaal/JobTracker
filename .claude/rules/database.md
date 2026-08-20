# Database Rules

Use PostgreSQL with Entity Framework Core.

## Entities

The initial domain should include:

- JobApplication
- JobApplicationStatusHistory
- CV or CV document metadata
- CV scoring results where persistence is required

Do not create database tables for speculative future features.

## Status History

Status history is append-only.

When a status changes:

1. Update the current status.
2. Create a status history record.
3. Save both changes atomically.

The operation should use a transaction when necessary to ensure consistency.

## Migrations

When changing the database schema:

1. Create an Entity Framework migration.
2. Use meaningful migration names.
3. Do not manually modify existing applied migrations.
4. Update relevant documentation if configuration or setup changes.

## Data Integrity

Use:

- Primary keys.
- Foreign keys.
- Appropriate indexes.
- Required constraints where appropriate.

Do not rely solely on frontend validation.