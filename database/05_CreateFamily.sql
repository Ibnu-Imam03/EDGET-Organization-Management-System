
CREATE TABLE Family
(
    FamilyID INT IDENTITY(1,1) PRIMARY KEY,
    PersonID INT NOT NULL,
    FamilyName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(250) NOT NULL,
    Situation NVARCHAR(500) NULL,

    FOREIGN KEY (PersonID)
        REFERENCES Person(PersonID)
);
