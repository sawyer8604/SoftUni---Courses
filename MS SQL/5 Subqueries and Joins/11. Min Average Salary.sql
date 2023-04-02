SELECT top(1) AVG(e.Salary) AS AvgSalary
	FROM Employees AS e
	JOIN Departments As d ON e.DepartmentID = d.DepartmentID
	GROUP BY D.DepartmentID
	ORDER BY AvgSalary

-- OR 

SELECT
	MIN(a.AverageSalary) AS MinAverageSalary
FROM
(
	SELECT 
		e.[DepartmentID],
		AVG(e.[Salary]) AS [AverageSalary]
	FROM [Employees] AS [e]
	GROUP BY e.[DepartmentID]
) AS [a]