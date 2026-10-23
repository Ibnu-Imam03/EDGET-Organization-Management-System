# EDGET Organization Management System — Requirements

## 1. Introduction

### 1.1 Purpose

The purpose of this document is to define the requirements for the EDGET Organization Management System. The system aims to organize the activities, information, and responsibilities of EDGET.

### 1.2 Organization Overview

EDGET is a student-led organization connected to Adama Science and Technology University (ASTU). Its student volunteers support children through educational activities, including Saturday teaching sessions and individual home teaching.

The organization also conducts family visits (Ziyara), manages finances and fundraising, organizes events, and maintains organizational information.

## 2. Organization Structure

The organization has six main leadership areas:

1. Executive Leadership
2. Academic Sector
3. Ziyara Sector
4. Finance Sector
5. Event Sector
6. Information Sector

## 3. Functional Requirements

### 3.1 Executive Leadership

The system should support executive responsibilities, including:

- Managing organization members and sectors.
- Monitoring activities across sectors.
- Accessing relevant reports.
- Coordinating organizational activities.

### 3.2 Academic Sector

The system should support:

- Registering children and their family information.
- Managing student volunteers who teach children.
- Recording teaching assignments.
- Recording Saturday teaching sessions.
- Recording individual home-teaching sessions.
- Tracking children's educational progress.
- Recording teaching activities and relevant reports.

### 3.3 Ziyara Sector

The system should support:

- Planning family visits, usually every two weeks.
- Recording the families or homes selected for visits.
- Organizing members into teams.
- Assigning teams to visit destinations.
- Recording visit details and outcomes.
- Submitting and reviewing visit reports.

### 3.4 Finance Sector

The system should support:

- Recording income and expenses.
- Recording donations and contributions.
- Managing fundraising activities, such as chocolate sales.
- Categorizing financial transactions.
- Generating financial summaries and reports.

### 3.5 Event Sector

The system should support:

- Recording organizational events.
- Managing welcome events, closing events, trips, and other activities.
- Recording participating members.
- Maintaining relevant event information.

### 3.6 Information Sector

The system should support:

- Managing organizational documents and information.
- Publishing announcements.
- Recording meetings and meeting minutes.
- Maintaining important organizational records.

## 4. User Roles and Access

The system may provide different access permissions for:

- **Executives:** oversee organizational activities and access authorized reports.
- **Sector Leaders:** manage activities and records related to their sectors.
- **Volunteers:** access information and perform activities permitted by their assigned roles.

The final permissions will be confirmed with EDGET leadership before implementation.

## 5. Non-Functional Requirements

### 5.1 Usability

The system should be easy to learn and use, including for users with limited technical experience.

### 5.2 Security

The system should protect children's information, family contact details, and financial records from unauthorized access.

### 5.3 Data Integrity

The system should maintain accurate and consistent records and prevent invalid relationships between related records.

### 5.4 Maintainability

The application should be organized so that developers can fix problems, add features, and maintain the system efficiently.

### 5.5 Reliability

The system should minimize data loss and provide an appropriate backup and recovery approach.

## 6. Development Scope

The initial development process will include:

1. Requirements analysis and confirmation.
2. Entity identification and attribute definition.
3. Entity-Relationship Diagram (ERD) design.
4. Database schema design.
5. User interface design.
6. Application development.
7. Testing and deployment.

## 7. Open Questions

The following details must be confirmed before finalizing the database design:

- Can one child have multiple assigned teaching volunteers?
- Which child and family details must be stored?
- What information must each teaching report contain?
- How should donations and fundraising sales be recorded?
- Who can view, create, update, and delete each type of record?
- Should the system support file uploads and data exports?
- Where will the system be hosted, and how will backups be managed?

## 8. Current Status

**Status:** Initial requirements draft.

This document is a starting point. The requirements must be reviewed with EDGET executives and sector leaders before the database and application design are finalized.
