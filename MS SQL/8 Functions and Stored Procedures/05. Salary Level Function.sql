CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @result VARCHAR(50)

	IF(@salary < 30000)
		BEGIN 
		SET @result = 'Low'
		END
	ELSE IF(@salary BETWEEN 30000 AND 50000)
		BEGIN 
		SET @result = 'Average'
		END
	ELSE
		SET @result = 'High'

	RETURN @result
END

SELECT FirstName, dbo.ufn_GetSalaryLevel(Salary)
FROM Employees


-- OR ------------------------------------------------------------

CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(50)
BEGIN
	RETURN CASE
		WHEN @salary < 30000 THEN 'Low'
		WHEN @salary <= 50000 THEN 'Average'
		ELSE 'High'		
	END
END

EXEC ufn_GetSalaryLevel 13500.00