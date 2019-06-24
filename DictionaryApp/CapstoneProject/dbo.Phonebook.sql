CREATE TABLE [dbo].[Phonebook] (
    [Name]        NVARCHAR (50)  NOT NULL,
    [Filename]    NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

