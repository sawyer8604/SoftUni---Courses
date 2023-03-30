SELECT * FROM 
(
	SELECT EmployeeID, FirstName, LastName, Salary,
	DENSE_RANK() OVER(PARTITION BY Salary ORDER BY EmployeeID) AS Ranked
	FROM Employees 
) AS Result

WHERE Salary BETWEEN 10000  AND 50000 AND Ranked = 2
ORDER BY Salary DESC