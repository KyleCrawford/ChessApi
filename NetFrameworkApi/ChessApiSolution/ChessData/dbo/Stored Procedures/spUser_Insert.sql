CREATE PROCEDURE [dbo].[spUser_Insert]
	@Id NVARCHAR(128),
	@Username NVARCHAR(50),
	@Email NVARCHAR(256),
	@CreatedDate DATETIME2
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.[User](Id, Username, Email, CreatedDate)
	VALUES (@Id, @Username, @Email, @CreatedDate)
END