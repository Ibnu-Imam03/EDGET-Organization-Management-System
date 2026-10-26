CREATE TABLE Executive
(
    ExecutiveID INT IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL,
    SectorID INT NOT NULL,
    Position VARCHAR(100) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NULL,

    

    FOREIGN KEY (MemberID)
        REFERENCES Member(MemberID),

    FOREIGN KEY (SectorID)
        REFERENCES Sector(SectorID),

    CHECK (EndDate IS NULL OR EndDate >= StartDate)
);
GO
