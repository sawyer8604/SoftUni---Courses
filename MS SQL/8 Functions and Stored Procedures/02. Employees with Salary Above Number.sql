CREATE PROC usp_GetEmployeesSalaryAboveNumber(@inputNumber DECIMAL(15,2))
AS
SELECT FirstName, LastName
FROM Employees
WHERE Salary >= @inputNumber

EXEC usp_GetEmployeesSalaryAboveNumber 48100