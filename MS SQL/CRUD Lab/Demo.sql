USE SoftUni1

SELECT FirstName, LastName, JobTitle FROM Employees

SELECT FirstName + ' ' + LastName AS [Full Name], JobTitle As [Job Title], Salary
FROM Employees

SELECT * FROM Employees
WHERE Salary >= 50000

SELECT * FROM Employees
WHERE Salary < 10000


SELECT * FROM Employees
WHERE HireDate < '2002-01-01'

SELECT * FROM Employees
WHERE HireDate > '2002'

SELECT * FROM Employees
WHERE FirstName > 'X' -- name begin with y or z

SELECT * FROM Employees
WHERE  HireDate < '2002' AND
	   Salary > 50000

SELECT * FROM Employees
WHERE  Salary > 50000 OR 
	   DepartmentId = 1

SELECT * FROM Employees
WHERE  NOT (Salary > 50000) OR DepartmentId = 1

SELECT * FROM Employees
WHERE  NOT (Salary > 50000 OR DepartmentId = 1)
-- smaller than 50k and differnt department

SELECT * FROM Employees
WHERE  Salary > 20000 AND Salary < 50000

SELECT * FROM Employees
WHERE  DepartmentId IN(1, 2, 3, 4)

SELECT FirstName, LastName, Salary FROM Employees
WHERE  Salary > 40000 ORDER BY Salary DESC

CREATE VIEW v_EmpleyeesWithHighestSalary AS
SELECT FirstName, LastName, Salary FROM Employees
WHERE  Salary > 40000 

