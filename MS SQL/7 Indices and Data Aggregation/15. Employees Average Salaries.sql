SELECT * INTO MyNewTable
FROM Employees
WHERE Salary > 30000

DELETE From MyNewTable
WHERE ManagerID = 42

UPDATE MyNewTable
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary)
FROM MyNewTable
GROUP BY DepartmentID


SELECT *
FROM Employees