﻿CREATE TABLE [dbo].[People] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NOT NULL,
    [LastName]     NVARCHAR (50) NOT NULL,
    [EmailAddress] NVARCHAR (50) NOT NULL,
    [Mobile]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED ([Id] ASC)
);

