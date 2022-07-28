IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220726005023_CriacaoBD')
BEGIN
    CREATE TABLE [Clientes] (
        [ClienteId] int NOT NULL IDENTITY,
        [ClientePerfil] int NOT NULL,
        [ClienteNome] nvarchar(max) NULL,
        [ClienteEmpresa] nvarchar(max) NULL,
        [ClienteNomeFantasia] nvarchar(max) NULL,
        [ClienteCpfCnpj] nvarchar(max) NULL,
        [ClienteTelefone] nvarchar(max) NULL,
        [ClienteCelular] nvarchar(max) NULL,
        [ClienteEmail] nvarchar(max) NULL,
        [ClienteRua] nvarchar(max) NULL,
        [ClienteNumero] nvarchar(max) NULL,
        [ClienteCep] nvarchar(max) NULL,
        [ClienteCidade] nvarchar(max) NULL,
        [ClienteEstado] nvarchar(max) NULL,
        [ClienteEndComplem] nvarchar(max) NULL,
        CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220726005023_CriacaoBD')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220726005023_CriacaoBD', N'2.1.14-servicing-32113');
END;

GO

