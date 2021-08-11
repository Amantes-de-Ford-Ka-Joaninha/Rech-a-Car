CREATE TABLE [dbo].[TBVeiculos] (
    [MODELO]        VARCHAR (50)    NOT NULL,
    [MARCA]         VARCHAR (50)    NOT NULL,
    [QUILOMETRAGEM] INT             NOT NULL,
    [ANO]           INT             NOT NULL,
    [PLACA]         VARCHAR (50)    NOT NULL,
    [CAPACIDADE]    INT             NOT NULL,
    [PORTAS]        INT             NOT NULL,
    [CHASSI]        VARCHAR (50)    NOT NULL,
    [PORTA_MALAS]   VARCHAR (50)    NOT NULL,
    [AUTOMATICO]    BIT             NOT NULL,
    [FOTO]          VARBINARY (MAX) NOT NULL,
    [ID]            INT             NOT NULL
);

