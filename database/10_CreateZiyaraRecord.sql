
USE EDGET_CharityDB;
GO

CREATE TABLE ZiyaraRecord
(
    ZiyaraRecordID INT IDENTITY(1,1) PRIMARY KEY,

    ZiyaraSessionID INT NOT NULL,
    ChildID INT NOT NULL,

    VisitSummary NVARCHAR(500) NULL,

    HomeTeachingProvided BIT NOT NULL DEFAULT 0,

    FollowUpRequired BIT NOT NULL DEFAULT 0,

    Remarks NVARCHAR(500) NULL,

    FOREIGN KEY (ZiyaraSessionID)
        REFERENCES ZiyaraSession(ZiyaraID),

    FOREIGN KEY (ChildID)
        REFERENCES Child(ChildID)
);
GO
