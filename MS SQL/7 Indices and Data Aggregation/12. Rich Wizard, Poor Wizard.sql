SELECT SUM(Guest.DepositAmount - Host.DepositAmount) AS SumDifference
FROM WizzardDeposits AS Host
JOIN WizzardDeposits AS Guest ON Host.Id = Guest.Id + 1

