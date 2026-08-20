# Testing Workflow

When testing a feature:

## Backend

Run:

1. Build.
2. Relevant unit tests.
3. Relevant integration tests.

## Frontend

Run:

1. Type checking where configured.
2. ESLint.
3. Prettier check.
4. Relevant frontend tests.

## End-to-End

Run Playwright tests for changed user workflows.

If tests cannot run:

- Explain why.
- Do not claim that validation passed.