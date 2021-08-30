﻿CREATE TABLE [dbo].[TBSenha] (
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    [ID_FUNCIONARIO] INT             NOT NULL,
    [HASH_SENHA]     VARCHAR (MAX)   NOT NULL,
    [SALT]           VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_TBSenha] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TBSenha_TBFuncionario] FOREIGN KEY ([ID_FUNCIONARIO]) REFERENCES [dbo].[TBFuncionario] ([ID])
);



