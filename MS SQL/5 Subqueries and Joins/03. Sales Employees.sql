SELECT e.EmployeeID, e.FirstName, e.LastName, d.Name
	FROM Employees AS e
	JOIN Departments As d ON d.DepartmentID = e.DepartmentID
	WHERE D.Name = 'Sales'
ORDER BY e.EmployeeID