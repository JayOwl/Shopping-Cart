CREATE TABLE [dbo].[Products] (
    [ProductID]   INT            IDENTITY (1, 1) NULL,
    [ProductName] NVARCHAR (100) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [ImagePath]   NVARCHAR (MAX) NULL,
    [UnitPrice]   FLOAT (53)     NULL,
    [CategoryID]  INT            NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([ProductID] ASC),
    CONSTRAINT [FK_dbo.Products_dbo.Categories_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([CategoryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CategoryID]
    ON [dbo].[Products]([CategoryID] ASC);

