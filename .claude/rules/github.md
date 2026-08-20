# GitHub Rules

The repository is:

Trishaal/JobTracker

Use GitHub integration when repository information is required.

## Pull Requests

Before creating or updating a pull request:

1. Check the diff.
2. Ensure unrelated files are not included.
3. Run relevant validation.
4. Use a Conventional Commit style title.
5. Complete the pull request template.

## Commit Messages

Follow Conventional Commits.

Examples:

- feat: add job application creation
- fix: preserve status change timestamps
- test: add job application integration tests
- chore: update frontend dependencies

## CI

GitHub Actions should validate:

- Frontend build.
- Frontend ESLint.
- Frontend Prettier.
- Backend build.
- Backend code style.
- Backend unit tests.
- Backend integration tests.
- Playwright tests.
- Pull request title.
- Commit message conventions where configured.

Do not bypass failing checks unless explicitly requested.

## GitHub Wiki Documentation

Project documentation is maintained in the GitHub Wiki.

When documentation is relevant:

1. Search or retrieve only the required Wiki page.
2. Do not retrieve every Wiki page.
3. Use the Wiki as the source of truth for detailed project documentation.

Update the relevant Wiki documentation when changes affect:

- Architecture.
- Application features.
- Database design.
- Authentication.
- Infrastructure.
- Local development.
- Testing.
- CI/CD.
- Configuration.

Do not update documentation for unrelated changes.

The repository README should remain concise and focus on:

- Project overview.
- Technology stack.
- Prerequisites.
- Local setup.
- Running the application.
- Running tests.
- Links to detailed GitHub Wiki documentation.

# Git Rules

## Before Changes

Always check:

- Current branch.
- Working tree status.
- Recent commits when relevant.

Do not overwrite existing uncommitted user changes.

## Branches

Use feature branches for development.

Do not commit directly to main unless explicitly requested.

## Commits

Use Conventional Commits.

Examples:

feat: add job application tracking
fix: correct status history timestamp
test: add application integration tests
docs: update architecture documentation

Keep commits focused.

Do not mix unrelated changes.

## Pull Requests

Before creating a PR:

1. Review git diff.
2. Check changed files.
3. Run relevant tests.
4. Check formatting.
5. Ensure the PR title follows Conventional Commits.
6. Complete the PR template.

## Pull / Merge

When asked to pull or merge:

1. Check git status first.
2. Protect existing uncommitted changes.
3. Perform only the requested Git operation.
4. If conflicts occur, inspect only affected files.
5. Resolve conflicts carefully.
6. Run relevant tests after resolving conflicts.

Do not automatically push or merge unless explicitly requested.

## Destructive Operations

Do not execute without explicit confirmation:

- git reset --hard
- git clean -fd
- git push --force
- deleting branches
- rewriting shared history

## GitHub

Repository:

Trishaal/JobTracker

Use GitHub integration when repository or pull request information is required.