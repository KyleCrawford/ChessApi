CREATE PROCEDURE [dbo].[spGetUserData]
	@Id NVARCHAR(128)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, Username, Email, CreatedDate
	FROM [dbo].[User]
	WHERE Id = @Id
END 