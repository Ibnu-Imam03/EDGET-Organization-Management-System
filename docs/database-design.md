# EDGET Organization Management System — Database Design

## 1. Overview

This document describes the initial database design for the EDGET Organization Management System, a system intended to support the organization's educational activities, Ziyara visits, events, financial management, and documentation.

The database is being designed using a relational model, with SQL Server as the planned database management system.

## 2. Design Objectives

- Maintain accurate records of members and children.
- Record teaching activities and children's learning progress.
- Manage Ziyara sessions, participating members, and family visits.
- Record organizational events.
- Track income, expenses, and fundraising activities.
- Manage organizational documents and sector reports.
- Reduce data duplication through normalization and appropriate relationships.

## 3. Entities

The initial design includes the following entities:

### Person and Organization Management
- Person
- Member
- Executive
- Child
- Family
- Sector

### Academic Management
- TeachingRecord

### Ziyara Management
- ZiyaraSession
- ZiyaraSessionMember
- ZiyaraRecord

### Event Management
- EventRecord

### Finance Management
- FinanceTransaction
- FinanceCategory
- FundraisingSale

### Information and Reporting
- Document
- Report

## 4. Key Design Decisions

- **Person:** Stores shared personal information.
- **Member:** Stores ASTU student and membership information and references Person.
- **Executive:** Stores leadership assignments and sector responsibilities.
- **TeachingRecord:** Records teaching activities, including the child taught, teaching member, and executive who entered the record.
- **ZiyaraSession:** Stores information about a planned or completed Ziyara activity and the executive leading it.
- **ZiyaraSessionMember:** Connects members to Ziyara sessions and records attendance.
- **ZiyaraRecord:** Stores details of the families visited and the outcomes of those visits.
- **EventRecord:** Stores information about organizational events.
- **FinanceTransaction:** Records organizational income and expenses.
- **FinanceCategory:** Classifies financial transactions.
- **FundraisingSale:** Records fundraising sales and links them to financial transactions.
- **Document:** Stores organizational document metadata.
- **Report:** Stores reports submitted by sectors or members.

## 5. Relationships and Keys

Primary keys (PK) uniquely identify records. Foreign keys (FK) reference records in related tables.

The design includes relationships such as:

- Person to Member
- Person to Child
- Member to Executive
- Sector to Executive
- Child to TeachingRecord
- Member to TeachingRecord
- Executive to TeachingRecord
- Executive to ZiyaraSession
- ZiyaraSession to ZiyaraSessionMember
- Member to ZiyaraSessionMember
- ZiyaraSession to ZiyaraRecord
- Family to ZiyaraRecord
- FinanceCategory to FinanceTransaction
- Member to FundraisingSale
- Member to Document
- Sector to Report

The final ERD will define the cardinality and participation constraints for each relationship.

## 6. Data Integrity and Normalization

The database design will aim to:

- Assign a primary key to every entity.
- Use foreign keys to maintain referential integrity.
- Enforce uniqueness for identifiers such as StudentID.
- Prevent duplicate member registrations in the same Ziyara session.
- Avoid unnecessary duplication of personal and financial information.
- Apply suitable data types, validation rules, and constraints.

## 7. Development Status

**Current phase:** Initial database design.

Planned next steps:

1. Finalize entity attributes and keys.
2. Validate relationships and cardinalities.
3. Complete the Entity-Relationship Diagram (ERD).
4. Review normalization and data integrity.
5. Implement the schema in SQL Server.
6. Develop the application using C#, ADO.NET, and a three-tier architecture.

*Note: This document describes the proposed design. Relationships, constraints, and attributes may change during validation and implementation.*
