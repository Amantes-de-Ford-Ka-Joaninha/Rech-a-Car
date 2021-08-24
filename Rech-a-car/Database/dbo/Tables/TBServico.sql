CREATE TABLE [dbo].[TBServicos] (
    [Id]   INT    IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (100) NOT NULL,
    [TipoServico]  VARCHAR (100) NULL,
    [Valor] DECIMAL (19) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);