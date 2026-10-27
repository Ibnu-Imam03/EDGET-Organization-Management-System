
USE EDGET_CharityDB;
GO

CREATE TABLE ZiyaraSessionMember
(
    ZiyaraSessionMemberID INT IDENTITY(1,1) PRIMARY KEY,

    ZiyaraSessionID INT NOT NULL,

    MemberID INT NOT NULL,

    -- 0 = Absent, 1 = Attended
    AttendanceStatus BIT NOT NULL DEFAULT 0,

    FOREIGN KEY (ZiyaraSessionID)
        REFERENCES ZiyaraSession(ZiyaraID),

    FOREIGN KEY (MemberID)
        REFERENCES Member(MemberID),

    -- A member can have only one attendance record per session.
    UNIQUE (ZiyaraSessionID, MemberID)
);
GO
