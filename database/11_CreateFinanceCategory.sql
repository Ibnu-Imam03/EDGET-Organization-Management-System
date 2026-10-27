
USE EDGET_CharityDB;
GO

CREATE TABLE FinanceCategory
(
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,

    CategoryName NVARCHAR(100) NOT NULL UNIQUE,

    -- 0 = Expense, 1 = Income
    TransactionType BIT NOT NULL,

    Description NVARCHAR(250) NOT NULL,

    -- 1 = Active, 0 = Inactive
    Status BIT NOT NULL DEFAULT 1
);
GO
