CREATE TABLE [dbo].[tblEmployee] (
    [EmployeeID]    INT            NOT NULL,
    [FirstName]     NVARCHAR (50)  NOT NULL,
    [LastName]      NVARCHAR (50)  NOT NULL,
    [Gender]        NVARCHAR (50)  NOT NULL,
    [NINumber]      NVARCHAR (50)  NOT NULL,
    [DateOfBirth]   DATETIME       NOT NULL,
    [MaritalStatus] NVARCHAR (50)  NOT NULL,
    [IsMember]      BIT            NOT NULL,
    [Address]       NVARCHAR (50)  NOT NULL,
    [City]          NVARCHAR (50)  NOT NULL,
    [PostCode]      NVARCHAR (50)  NOT NULL,
    [Country]       NVARCHAR (50)  NOT NULL,
    [PhoneNumber]   NVARCHAR (50)  NOT NULL,
    [Email]         NVARCHAR (50)  NOT NULL,
    [Notes]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

