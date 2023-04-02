SELECT TOP(5) e.EmployeeID, e.JobTitle, a.AddressID, a.AddressText
	FROM Employees AS e
	JOIN Addresses As a ON a.AddressID = e.AddressID
ORDER BY e.AddressID