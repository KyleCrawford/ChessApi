CREATE TABLE [dbo].[UserGame]
(
	[GameId] INT NOT NULL PRIMARY KEY,
	[PlayerOne] NVARCHAR(128) NOT NULL,
	[PlayerTwo] NVARCHAR(128) NULL,

	CONSTRAINT [FK_UserGame_ToGame] FOREIGN KEY (GameId) REFERENCES Game(Id),
	CONSTRAINT [FK_UserGame_ToUserOne] FOREIGN KEY (PlayerOne) REFERENCES [User](Id),
	CONSTRAINT [FK_UserGame_ToUserTwo] FOREIGN KEY (PlayerTwo) REFERENCES [User](Id)
)
