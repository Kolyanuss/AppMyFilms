CREATE TABLE [dbo].[Films] (
    [Id]            INT           NOT NULL,
    [NameFilm]      NVARCHAR (50) NOT NULL,
    [ReleaseData]   DATE          NULL,
    [Country]       NVARCHAR (50) NULL,
    [DescriptionId] INT           NULL,
    CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED ([Id] ASC)
);

