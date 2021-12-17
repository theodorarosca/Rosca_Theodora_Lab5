CREATE TABLE [dbo].[Book] (
    [ID]     INT             IDENTITY (1, 1) NOT NULL,
    [Title]  NVARCHAR (MAX)  NULL,
    [Author] NVARCHAR (MAX)  NULL,
    [Price]  DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED ([ID] ASC)
);

