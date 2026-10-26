CREATE TABLE Child
(
    ChildID INT IDENTITY(1,1) PRIMARY KEY,
    PersonID INT NOT NULL UNIQUE
        REFERENCES Person(PersonID),

    FamilyID INT NOT NULL
        REFERENCES Family(FamilyID),

    Age INT NULL
        CHECK (Age IS NULL OR Age BETWEEN 0 AND 18),

    Grade VARCHAR(30) NOT NULL,
    SchoolName NVARCHAR(150) NOT NULL
);
GO
