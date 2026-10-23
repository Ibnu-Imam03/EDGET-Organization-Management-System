# EDGET Organization Management System — Entities

## 1. Organization Management

### 1.1 Executive
Represents the students responsible for managing the organization.

### 1.2 Sector
Represents the organization's six sectors: Academic, Ziyara, Finance, Event, Information, and Executive Leadership.

### 1.3 SectorMember
Represents a member's assignment to a sector and their responsibility within it.

## 2. Academic Management

### 2.1 Child
Represents a child who receives educational support.

### 2.2 Family
Stores information about a child's family and contact details.

### 2.3 Volunteer
Represents an ASTU student who participates in teaching or Ziyara activities.

### 2.4 TeachingAssignment
Records which volunteer is assigned to teach which child.

### 2.5 TeachingSession
Represents a teaching activity, including Saturday teaching or individual home teaching.

### 2.6 TeachingRecord
Stores the educational details of a teaching session, including the subject, topic, starting point, stopping point, and homework.

## 3. Ziyara Management

### 3.1 ZiyaraVisit
Represents a planned family visit.

### 3.2 ZiyaraTeam
Represents a team organized for a Ziyara visit.

### 3.3 TeamMember
Records which volunteers belong to each Ziyara team.

### 3.4 VisitReport
Stores the report and outcomes of a completed family visit.

## 4. Finance Management

### 4.1 Contributor
Represents a person or organization that contributes funds or other support.

### 4.2 FinanceTransaction
Records financial income and expenses.

### 4.3 FinanceCategory
Classifies transactions, such as donations, teaching materials, and fundraising.

### 4.4 FundraisingSale
Records fundraising activities, such as chocolate sales.

## 5. Event Management

### 5.1 Event
Represents an organizational event, such as a welcome event, closing event, or trip.

### 5.2 EventParticipation
Records the volunteers participating in an event.

## 6. Information Management

### 6.1 Document
Stores information about organizational documents and files.

### 6.2 Announcement
Represents announcements shared with organization members.

### 6.3 Meeting
Records organization or sector meetings.

### 6.4 MeetingMinutes
Stores meeting discussions, decisions, and action points.

## Important Notes

- These entities are preliminary and must be confirmed against EDGET's actual workflows.
- Each entity will later receive attributes, a primary key, and any required foreign keys.
- We will define relationships and cardinalities before finalizing the ERD.
- User accounts and permissions will be designed separately after confirming how members should access the system.
