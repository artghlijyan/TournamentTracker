CREATE PROCEDURE [dbo].[sp_InsertIntoPeople]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@Mobile nvarchar(50),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO People (FirstName, LastName, EmailAddress, Mobile)
	VALUES (@FirstName, @LastName, @EmailAddress, @Mobile)

	SELECT @Id = SCOPE_IDENTITY()
END
