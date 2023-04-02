SELECT e.EmployeeID, e.FirstName, e.ManagerID, m.FirstName AS ManagerName

	FROM Employees AS e
	JOIN Employees As m ON e.ManagerID = m.EmployeeID		
	WHERE  e.ManagerID IN(3,7)
	ORDER BY e.EmployeeID

