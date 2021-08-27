﻿CREATE TABLE [dbo].[TBCategoria] (
    [PRECO_KM]    DECIMAL (18) NOT NULL,
    [DIARIA]      DECIMAL (18) NOT NULL,
    [KM_FRANQUIA] INT          NOT NULL,
    [PRECOLIVRE]  DECIMAL (18) NOT NULL,
    [NOME]        VARCHAR (50) NOT NULL,
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TBCategoria] PRIMARY KEY CLUSTERED ([ID] ASC)
);

