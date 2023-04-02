SELECT TOP(50)
	e.EmployeeID,
	e.FirstName + ' ' + e.LastName As EmployeeName,
	dm.FirstName + ' ' + dm.LastName AS ManagerName,
	d.Name AS DepartmentName

FROM Employees AS e
	JOIN Employees As dm ON e.ManagerID = dm.EmployeeID
	JOIN Departments As d ON e.DepartmentID = d.DepartmentID		
ORDER BY e.EmployeeID