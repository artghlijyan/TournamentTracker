CREATE TABLE [dbo].[Prizes] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [PlaceNumber]    INT           NOT NULL,
    [PlaceName]      NVARCHAR (50) NOT NULL,
    [PrizeAmount]    MONEY         NOT NULL,
    [PrizePrcentage] FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

