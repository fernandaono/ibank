IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Clientes] (
    [ClienteId] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Agencia] int NOT NULL,
    [Conta] int NOT NULL,
    [Senha] int NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200427210702_InitialCreate', N'2.1.14-servicing-32113');

GO

