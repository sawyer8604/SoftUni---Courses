CREATE FUNCTION [ufn_CashInUsersGames] (@gameName VARCHAR(50))
RETURNS TABLE
AS
	RETURN
		SELECT SUM([Cash]) AS [SumCash]
		  FROM (
				SELECT ROW_NUMBER() OVER(ORDER BY [ug].[Cash]DESC) AS [RowNumber],
			           [ug].[Cash]
				  FROM [UsersGames] AS [ug]
				  JOIN [Games] AS [g] ON [ug].[GameId] = [g].Id
				 WHERE [g].[Name] = @gameName
			   ) AS [SubRowQuery]
		 WHERE [RowNumber] % 2 <>0


SELECT * FROM [dbo].[ufn_CashInUsersGames]('Love in a mist')