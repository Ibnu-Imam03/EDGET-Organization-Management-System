
USE EDGET_CharityDB;
GO

CREATE TABLE ZiyaraSession
(
    ZiyaraID INT IDENTITY(1,1) PRIMARY KEY,

    LedByExecutiveID INT NOT NULL,

    VisitDate DATETIME NOT NULL,

    Destination VARCHAR(100) NOT NULL,

    Purpose VARCHAR(100) NOT NULL,

    -- 0 = Planned, 1 = Completed
    Status BIT NOT NULL DEFAULT 0,

    FOREIGN KEY (LedByExecutiveID)
        REFERENCES Executive(ExecutiveID)
);
GO
