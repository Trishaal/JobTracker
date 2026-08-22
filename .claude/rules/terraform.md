---
paths:
  - "infrastructure/**/*.tf"
  - "infrastructure/**/*.tfvars"
---

# Terraform Rules

Use Terraform for AWS infrastructure.

## Principles

- Keep modules simple.
- Do not create modules for trivial one-time resources.
- Use variables for environment-specific values.
- Use outputs for important resource identifiers.
- Never commit secrets in tfvars files.

## Validation

Before completing infrastructure changes:

1. Run terraform fmt.
2. Run terraform validate.
3. Review terraform plan.
4. Do not apply destructive changes without clear confirmation.

## Naming

Use consistent resource naming.

Prefer:

jobtracker-dev-resource

over unclear or inconsistent names.

Avoid hard-coded environment-specific identifiers.