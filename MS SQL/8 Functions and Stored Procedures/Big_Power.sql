CREATE FUNCTION	udf_BigPower(@Base INT, @Exp INT)
RETURNS DECIMAL(38)
AS
BEGIN	
	DECLARE @Result DECIMAL(38) = 1;
	WHILE (@Exp > 0)
	BEGIN
		SET @Result = @Result * @Base;
		SET @Exp = @Exp - 1;
	END
	RETURN @Result
END

SELECT dbo.udf_BigPower(2, 100)