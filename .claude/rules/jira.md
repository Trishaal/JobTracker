# Jira Rules

When a Jira ticket is explicitly provided:

1. Retrieve that ticket only.
2. Read the title, description, and acceptance criteria first.
3. Do not automatically retrieve:
   - Every comment
   - The entire epic
   - All linked issues
   - Attachments
   - Unrelated tickets

Retrieve additional Jira information only when required to understand or implement the requested work.

After reading the ticket:

1. Identify the required behaviour.
2. Identify affected areas of the application.
3. Inspect only relevant code.
4. Reuse existing patterns.
5. Implement the smallest complete solution.

Do not invent requirements not present in the ticket.

If requirements are ambiguous, inspect related code and documentation before asking unnecessary questions.