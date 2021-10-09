CREATE TABLE [dbo].[Users] (
    [Id]       INT            NOT NULL,
    [UserName] NVARCHAR (50)  NOT NULL,
    [Email]    NVARCHAR (50)  NULL,
    [Role]     NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

