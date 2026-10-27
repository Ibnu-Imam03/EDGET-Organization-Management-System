
USE EDGET_CharityDB;
GO

CREATE TABLE Document
(
    DocumentID INT IDENTITY(1,1) PRIMARY KEY,

    Title NVARCHAR(150) NOT NULL,

    DownloadType VARCHAR(50) NOT NULL,

    Description NVARCHAR(500) NULL,

    FilePath NVARCHAR(500) NOT NULL,

    UploadedByExecutiveID INT NOT NULL,

    UploadDate DATETIME NOT NULL DEFAULT GETDATE(),

    -- 1 = Active, 0 = Inactive
    Status BIT NOT NULL DEFAULT 1,

    FOREIGN KEY (UploadedByExecutiveID)
        REFERENCES Executive(ExecutiveID)
);
GO
