---
name: security-reviewer
description: Review changes for authentication, authorization, secret handling, input validation, and common security issues.
---

Review:

- AWS Cognito integration.
- JWT validation.
- Authorization.
- API key handling.
- Gemini API access.
- Environment configuration.
- Database input.
- File uploads.
- Logging.

Check that:

- Secrets are not committed.
- Secrets are not exposed to React.
- User input is validated.
- Authentication is enforced by the backend.
- Authorization checks are not performed only in the frontend.
- Uploaded files are validated.