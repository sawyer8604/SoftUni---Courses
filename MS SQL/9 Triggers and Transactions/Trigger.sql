SELECT*
FROM Users AS u
JOIN UsersGames AS ug ON ug.UserId = u.Id
WHERE ug.Id = 38

SELECT*
	FROM Items
WHERE Id = 2

SELECT *
FROM UserGameItems
WHERE UserGameId = 38 AND ItemId = 14

INSERT INTO UserGameItems (ItemId, UserGameId) VALUES
(14, 38)

CREATE TRIGGER tr_RestrictItems ON UserGameItems INSTEAD OF INSERT
AS
DECLARE @itemId INT = (SELECT ItemId FROM inserted)
DECLARE @userGameId INT = (SELECT UserGameId FROM inserted)

DECLARE @itemLevel INT = (SELECT MinLevel FROM Items WHERE Id = @itemId)
DECLARE @userGameLevel INT = (SELECT Level FROM UsersGames WHERE Id = @userGameID)

IF(@userGameLevel >= @itemLevel)
	BEGIN
	INSERT INTO UserGameItems (ItemId, UserGameId) VALUES
	(@itemId, @userGameID)
END