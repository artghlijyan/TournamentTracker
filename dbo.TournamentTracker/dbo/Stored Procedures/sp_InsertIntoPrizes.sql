CREATE PROCEDURE [dbo].[sp_InsertIntoPrizes]
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePrcentage)
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount,	@PrizePercentage)

	SELECT @Id = SCOPE_IDENTITY()
END