---
paths:
  - "frontend/**/*.{ts,tsx}"
---

# Frontend Rules

## Technology

Use:

- React 19
- TypeScript
- Vite
- Tailwind CSS
- shadcn/ui

Do not introduce another UI framework unless explicitly required.

## Components

- Keep components focused.
- Prefer composition over large monolithic components.
- Extract reusable components when they have a genuine reuse case.
- Do not over-engineer abstractions.

## TypeScript

- Do not use `any` unless unavoidable.
- Define explicit types for API contracts.
- Prefer strongly typed API interactions.
- Reuse existing types where appropriate.

## Job Application Table

The main job application experience is table based.

Support:

- Viewing applications.
- Adding an application.
- Editing an application.
- Changing application status.

Changing the status must trigger the backend status history workflow.

The frontend must not independently create historical records.

## Styling

Use existing Tailwind and shadcn/ui patterns.

Do not add custom CSS when existing utilities or components are sufficient.

## Accessibility

Ensure:

- Form controls have labels.
- Buttons have meaningful accessible names.
- Keyboard interaction works for important workflows.