CREATE TABLE [dbo].[ListFilms] (
    [IdFilms] INT NOT NULL,
    [IdUser]  INT NOT NULL,
    CONSTRAINT [PK_ListFilms_1] PRIMARY KEY CLUSTERED ([IdFilms] ASC, [IdUser] ASC),
    CONSTRAINT [FK_ListFilms_Films] FOREIGN KEY ([IdFilms]) REFERENCES [dbo].[Films] ([Id]),
    CONSTRAINT [FK_ListFilms_Users] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[Users] ([Id])
);

