USE EDGET_CharityDB;
GO

CREATE TABLE EventRecord
(
    EventRecordID INT IDENTITY(1,1) PRIMARY KEY,
    LedByExecutiveID INT NOT NULL,
    EventName NVARCHAR(100) NOT NULL,
    EventType NVARCHAR(50) NOT NULL,
    EventDate DATETIME NOT NULL,
    Location NVARCHAR(150) NULL,
    Description NVARCHAR(500) NULL,
    Status BIT NOT NULL DEFAULT 1,

    FOREIGN KEY (LedByExecutiveID)
        REFERENCES Executive(ExecutiveID)
);
GO
