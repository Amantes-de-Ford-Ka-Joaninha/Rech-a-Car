CREATE TABLE [dbo].[TBDadosVeiculo] (
    [ID]            INT          NOT NULL,
    [QUILOMETRAGEM] INT          NOT NULL,
    [PRECO_KM]      DECIMAL (18) NOT NULL,
    [DIARIA]        DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_TBDadosVeiculo] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TBDadosVeiculo_TBVeiculo] FOREIGN KEY ([ID]) REFERENCES [dbo].[TBVeiculo] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);





