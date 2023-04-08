CREATE OR ALTER PROC usp_TransferFunds(
@FromAccoundId INT, @ToAccountId INT, @Amount MONEY)
AS
	BEGIN TRANSACTION
	IF (SELECT Balance FROM Accounts WHERE Id = @FromAccoundId) < @Amount
	BEGIN
		ROLLBACK;
		THROW 50001, 'Insufficient funds', 1;
	END

	IF NOT EXISTS(SELECT * FROM Accounts WHERE Id = @FromAccoundId)
	BEGIN
		ROLLBACK;
		THROW 50002, '@FromAccountId not found!', 1
	END

	IF NOT EXISTS(SELECT * FROM Accounts WHERE Id = @ToAccountId)
	BEGIN
		ROLLBACK;
		THROW 50003, '@FromAccountId not found!', 1
	END

	UPDATE Accounts SET Balance = Balance - @Amount WHERE Id = @FromAccoundId
	UPDATE Accounts SET Balance = Balance + @Amount WHERE Id = @ToAccountId