# AWS Rules

Use AWS Free Tier compatible services where practical.

Initial AWS services may include:

- AWS Cognito
- PostgreSQL infrastructure where appropriate
- Supporting AWS services only when justified

Prefer infrastructure as code.

Do not create AWS resources manually if Terraform is responsible for them.

Before adding a new AWS service:

1. Confirm why it is required.
2. Consider cost.
3. Consider Free Tier limits.
4. Check whether an existing service can satisfy the requirement.

Use environment-specific configuration.

Do not hard-code:

- AWS account IDs.
- Regions when configurable.
- Resource identifiers.
- Cognito IDs.
- URLs.