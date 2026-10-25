-- 1. Store basic information about people
CREATE TABLE Person
(
    PersonID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Sex VARCHAR(10) NULL,
    PhoneNumber VARCHAR(20) NULL,
    Email VARCHAR(100) NULL
);
GO

-- 2. Store the organization's sectors
CREATE TABLE Sector
(
    SectorID INT IDENTITY(1,1) PRIMARY KEY,
    SectorName NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500) NULL
);
GO
