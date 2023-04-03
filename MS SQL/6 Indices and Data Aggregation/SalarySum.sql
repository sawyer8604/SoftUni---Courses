SELECT
	d.Name, SUM(Salary) AS SalarySum
FROM Employees AS e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY SalarySum DESC