
USE EDGET_CharityDB;
GO

CREATE TABLE TeachingRecord
(
    TeachingRecordID INT IDENTITY(1,1) PRIMARY KEY,

    TeachingDate DATE NOT NULL,

    -- 0 = Morning, 1 = Evening
    Shift BIT NOT NULL,

    ChildID INT NOT NULL,
    MemberID INT NOT NULL,
    RecordedByExecutiveID INT NOT NULL,

    Subject NVARCHAR(100) NOT NULL,
    Topic NVARCHAR(200) NOT NULL,

    StartingPoint NVARCHAR(200) NULL,
    StoppingPoint NVARCHAR(200) NULL,

    HomeworkAssigned BIT NOT NULL DEFAULT 0,
    HomeworkCompleted BIT NOT NULL DEFAULT 0,

    FOREIGN KEY (ChildID) REFERENCES Child(ChildID),
    FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    FOREIGN KEY (RecordedByExecutiveID)
        REFERENCES Executive(ExecutiveID),

    -- Homework cannot be completed unless it was assigned.
    CHECK (
        HomeworkCompleted = 0
        OR HomeworkAssigned = 1
    )
);
GO
