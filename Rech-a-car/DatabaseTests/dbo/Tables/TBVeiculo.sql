CREATE TABLE [dbo].[TBVeiculo] (
    [MODELO]      VARCHAR (50)    NOT NULL,
    [MARCA]       VARCHAR (50)    NOT NULL,
    [ANO]         INT             NOT NULL,
    [PLACA]       VARCHAR (50)    NOT NULL,
    [CAPACIDADE]  INT             NOT NULL,
    [PORTAS]      INT             NOT NULL,
    [CHASSI]      VARCHAR (50)    NOT NULL,
    [PORTA_MALAS] VARCHAR (50)    NOT NULL,
    [CATEGORIA]   VARCHAR (50)    NOT NULL,
    [AUTOMATICO]  BIT             NOT NULL,
    [FOTO]        VARBINARY (MAX) NOT NULL,
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TBVeiculo] PRIMARY KEY CLUSTERED ([ID] ASC)
);

