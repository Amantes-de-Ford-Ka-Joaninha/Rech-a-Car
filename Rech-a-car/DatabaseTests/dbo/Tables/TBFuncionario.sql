CREATE TABLE [dbo].[TBFuncionario] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (110) NOT NULL,
    [CPF]            VARCHAR (14)  NOT NULL,
    [DataNascimento] DATE          NULL,
    [Endereço]       VARCHAR (200) NOT NULL,
    [Telefone]       VARCHAR (15)  NOT NULL,
    [Cargo]          VARCHAR (110) NULL
);

