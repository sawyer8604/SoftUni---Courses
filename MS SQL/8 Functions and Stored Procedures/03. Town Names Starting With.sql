CREATE PROC usp_GetTownsStartingWith(@input VARCHAR(50))
AS
SELECT Name AS Town
FROM Towns
WHERE Name LIKE @input + '%'

EXEC usp_GetTownsStartingWith b