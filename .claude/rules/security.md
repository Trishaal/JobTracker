# Security Rules

Never commit:

- API keys.
- Passwords.
- AWS access keys.
- Cognito client secrets.
- Database credentials.
- Gemini API keys.

Do not log:

- Access tokens.
- Refresh tokens.
- Passwords.
- API keys.
- Full sensitive configuration.

Secrets must remain server-side.

The frontend must never receive AWS credentials or Gemini API keys.

Validate user input on the backend.

Do not trust identifiers provided by the client without authorization checks.