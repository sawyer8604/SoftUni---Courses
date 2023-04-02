SELECT e.EmployeeID, e.FirstName,
	CASE 
		WHEN p.[StartDate] >= '2005-01-01' THEN NULL
		ELSE p.[Name]
	END AS [ProjectName]
	FROM Employees AS e
	LEFT JOIN EmployeesProjects As ep ON e.EmployeeID = ep.EmployeeID	
	LEFT JOIN Projects As p ON ep.ProjectID = p.ProjectID
	WHERE e.EmployeeID = 24 
