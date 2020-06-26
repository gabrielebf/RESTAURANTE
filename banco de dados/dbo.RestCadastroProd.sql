CREATE TABLE [dbo].[RestCadastroProd] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [tipo]       VARCHAR (35) NULL,
    [preco]      FLOAT (53)   NULL,
    [desconto]   FLOAT (53)   NOT NULL,
    [observacao] VARCHAR (50) NULL,
    [CategoriaId] INT NOT NULL, 
    CONSTRAINT [PK_RestCadastroProd] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_RestCadastroProd_RestPedidos] FOREIGN KEY ([id]) REFERENCES [dbo].[RestPedidos] ([id])
);

