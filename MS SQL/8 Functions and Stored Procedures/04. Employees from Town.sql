CREATE or alter PROC usp_GetEmployeesFromTown(@inputTown VARCHAR(50))
AS
SELECT e.FirstName, e.LastName
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON t.TownID = a.TownID
WHERE t.Name = @inputTown

EXEC usp_GetEmployeesFromTown Sofia