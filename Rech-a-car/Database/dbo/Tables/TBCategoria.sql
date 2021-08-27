CREATE TABLE [dbo].[TBCategoria] (
    [ID]            INT          NOT NULL,
    [QUILOMETRAGEM] INT          NOT NULL,
    [PRECO_KM]      DECIMAL (18) NOT NULL,
    [DIARIA]        DECIMAL (18) NOT NULL,
    [NOME]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TBCategoria] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TBCategoria_TBVeiculo] FOREIGN KEY ([ID]) REFERENCES [dbo].[TBVeiculo] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);





