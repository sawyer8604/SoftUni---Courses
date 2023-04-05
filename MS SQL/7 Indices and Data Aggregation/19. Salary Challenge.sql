SELECT TOP(10) FirstName, LastName, DepartmentID

FROM Employees em
WHERE Salary > (SELECT AVG(Salary)
				FROM Employees
				WHERE DepartmentID = em.DepartmentID
				GROUP BY DepartmentID)
ORDER BY DepartmentID
