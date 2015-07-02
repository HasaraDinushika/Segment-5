CREATE TABLE [dbo].[Registration] (
    [StudentID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]                VARCHAR (250)  NOT NULL,
    [Date Of Birth]       DATE           NULL,
    [Grade Point Average] DECIMAL (4, 2) NULL,
    [Active]              BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

