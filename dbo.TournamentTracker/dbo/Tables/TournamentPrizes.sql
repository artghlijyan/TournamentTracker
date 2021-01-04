CREATE TABLE [dbo].[TournamentPrizes] (
    [PrizeId] INT NOT NULL,
    CONSTRAINT [FK_TournamentPrizes_PrizeId] FOREIGN KEY ([PrizeId]) REFERENCES [dbo].[Prizes] ([Id])
);

