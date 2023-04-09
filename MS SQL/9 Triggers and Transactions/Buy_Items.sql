CREATE PROC usp_BuyItem @userId INT, @itemId INT, @gameID INT
AS
BEGIN TRANSACTION
DECLARE @user INT = (SELECT Id FROM Users WHERE Id = @userId)
DECLARE @item INT = (SELECT Id FROM Items WHERE Id = @itemId)

IF(@user IS NULL OR @item IS NULL)
BEGIN
	ROLLBACK
	RAISERROR('Invalid user or item Id!', 16, 1)
	RETURN
END

DECLARE @userCash DECIMAL(15,2) = (SELECT Cash FROM UsersGames WHERE UserId = @userId AND  GameId = @gameID)
DECLARE @itemPrice DECIMAL(15,2) = (SELECT Price FROM Items WHERE Id = @itemId)

IF(@userCash - @itemPrice < 0)
BEGIN
	ROLLBACK
	RAISERROR('Insufficient funds!', 16, 2)
	RETURN
END

UPDATE UsersGames
SET Cash -= @itemPrice
WHERE UserId = @userId AND GameId = @gameID

DECLARE @userGameId DECIMAL(15,2) = (SELECT Id FROM UsersGames WHERE UserId = @userId AND  GameId = @gameID)

INSERT INTO UserGameItems(ItemId, UserGameId) VALUES(@itemId, @gameID)

COMMIT


--baleremuda, loosenoise, inguinalself, buildingdeltoid, monoxideco
-- id between 251 and 299 including. 
GO

DECLARE @itemId INT = 251;

WHILE (@itemId <= 299)
BEGIN
	EXEC usp_BuyItem 22,@itemId, 212
	EXEC usp_BuyItem 37,@itemId, 212
	EXEC usp_BuyItem 52,@itemId, 212
	EXEC usp_BuyItem 61,@itemId, 212
	SET @itemId +=1;
END

DECLARE @counter INT = 501;

WHILE (@counter <= 539)
BEGIN
	EXEC usp_BuyItem 22,@counter, 212
	EXEC usp_BuyItem 37,@counter, 212
	EXEC usp_BuyItem 52,@counter, 212
	EXEC usp_BuyItem 61,@counter, 212
	SET @counter +=1;
END

SELECT *
FROM UsersGames
WHERE GameId = 212