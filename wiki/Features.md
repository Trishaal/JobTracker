# Features

This page tracks the feature implementation progress for the JobTracker application.

## Ordered Feature Roadmap

1. **Job Application CRUD Operations** (Current Next Feature)
   - Create, read, update, delete job applications
   - Table-based view of applications
   - Inline editing where appropriate
   - Ability to add a new job application
   - Ability to edit an existing application

2. **Status History Tracking**
   - Record every status change with timestamp
   - View status change history for each application
   - Prevent overwriting historical status information

3. **CV Upload and Management**
   - Upload CV files
   - Store CV metadata
   - Associate CV with job applications

4. **CV Scoring with Gemini Integration**
   - Send CV and job description to Gemini AI
   - Receive structured CV score and feedback
   - Store scoring results
   - Isolate AI provider behind application interface

5. **Authentication with AWS Cognito**
   - User registration and login
   - Secure API endpoints
   - Token validation on backend
   - Protect frontend from direct API key exposure

6. **Reporting and Analytics**
   - Generate reports based on application history
   - Status change analytics
   - Application trend visualization

7. **Application Settings and Configuration**
   - Environment-specific configuration
   - Secure handling of secrets
   - Configurable API endpoints

## Feature Status

- [ ] Job Application CRUD Operations
- [ ] Status History Tracking
- [ ] CV Upload and Management
- [ ] CV Scoring with Gemini Integration
- [ ] Authentication with AWS Cognito
- [ ] Reporting and Analytics
- [ ] Application Settings and Configuration

## Current Next Feature
Job Application CRUD Operations

## Completion Notes

