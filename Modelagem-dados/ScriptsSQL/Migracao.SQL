IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Usuarios] (
    [id] int NOT NULL IDENTITY,
    [nome] nvarchar(max) NOT NULL,
    [email] nvarchar(50) NOT NULL,
    [telefone] nvarchar(15) NOT NULL,
    [cpf] float NOT NULL,
    [idade] int NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Viagens] (
    [id] int NOT NULL IDENTITY,
    [destinoViagem] nvarchar(80) NOT NULL,
    [preco] float NOT NULL,
    [taxas] int NOT NULL,
    CONSTRAINT [PK_Viagens] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Passagens] (
    [id] int NOT NULL IDENTITY,
    [usuarioId] int NOT NULL,
    [viagemId] int NOT NULL,
    CONSTRAINT [PK_Passagens] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Passagens_Usuarios_usuarioId] FOREIGN KEY ([usuarioId]) REFERENCES [Usuarios] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Passagens_Viagens_viagemId] FOREIGN KEY ([viagemId]) REFERENCES [Viagens] ([id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Passagens_usuarioId] ON [Passagens] ([usuarioId]);
GO

CREATE INDEX [IX_Passagens_viagemId] ON [Passagens] ([viagemId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211214014059_Inicial', N'5.0.0');
GO

COMMIT;
GO

