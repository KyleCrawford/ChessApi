CREATE PROCEDURE [dbo].[spCreateGame]
	@Name NVARCHAR(100),
	@Code NVARCHAR(50),
	@BoardData NVARCHAR(MAX),
	@UserId NVARCHAR(128)
AS
BEGIN TRANSACTION
BEGIN
	SET NOCOUNT ON;

	-- Create the new game record
	INSERT INTO Game ([Name], Code, BoardData)
	VALUES (@Name, @Code, @BoardData)
	
	if @@ERROR <> 0
	BEGIN
		ROLLBACK TRANSACTION
		RETURN 2
	END

	-- Link the User and Game
	INSERT INTO UserGame (GameId, PlayerOne)
	VALUES (SCOPE_IDENTITY(), @UserId)

	if @@ERROR <> 0
	BEGIN
		ROLLBACK TRANSACTION
		RETURN 4
	END
COMMIT TRANSACTION
END
