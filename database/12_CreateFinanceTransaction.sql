
USE EDGET_CharityDB;
GO

CREATE TABLE FinanceTransaction
(
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,

    CategoryID INT NOT NULL,

    TransactionDate DATE NOT NULL,

    TransactionType BIT NOT NULL,

    UnitSale INT NULL,

    UnitAmount DECIMAL(10,2) NULL,

    TotalAmount DECIMAL(10,2) NOT NULL,

    StatusDescription NVARCHAR(250) NULL,

    ReferenceNumber VARCHAR(50) NULL,

    RecordedByExecutiveID INT NOT NULL,

    FOREIGN KEY (CategoryID)
        REFERENCES FinanceCategory(CategoryID),

    FOREIGN KEY (RecordedByExecutiveID)
        REFERENCES Executive(ExecutiveID),

    CHECK (TotalAmount > 0),

    CHECK (UnitSale IS NULL OR UnitSale > 0),

    CHECK (UnitAmount IS NULL OR UnitAmount > 0)
);
GO
