﻿CREATE TABLE [dbo].[TBClientePF] (
    [ID]              INT          IDENTITY (1, 1) NOT NULL,
    [NOME]            VARCHAR (50) NOT NULL,
    [TELEFONE]        VARCHAR (50) NOT NULL,
    [ENDERECO]        VARCHAR (50) NOT NULL,
    [DOCUMENTO]       VARCHAR (50) NOT NULL,
    [ID_CNH]          INT          NOT NULL,
    [DATA_NASCIMENTO] DATETIME     NOT NULL,
    CONSTRAINT [PK_TBClientePF] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TBClientePF_TBCnh] FOREIGN KEY ([ID_CNH]) REFERENCES [dbo].[TBCnh] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);


