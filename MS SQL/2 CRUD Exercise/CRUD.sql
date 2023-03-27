--Create an SQL query that finds all the available information about the Departments.
SELECT * FROM Departments

--3 Create an SQL query that finds all Department names.
SELECT [Name] FROM Departments

--4 Create an SQL query that finds the first name, last name, and salary for each employee.
SELECT FirstName, LastName, Salary FROM Employees

--5 Create an SQL query that finds the first name, last name, and salary for each employee.
SELECT FirstName, MiddleName, LastName FROM Employees

--6 Create an SQL query that finds the email address of each employee, by his first and last name. Consider that the email domain is softuni.bg. Emails should look like "John.Doe@softuni.bg". The produced column should be named "Full Email Address".
SELECT FirstName + '.' + LastName + '@softuni.bg' AS [Full Email Address] FROM Employees

--7 Create an SQL query that finds all different salaries of the employees. Display the salaries only in one column, named "Salary".
SELECT DISTINCT Salary FROM Employees

--8 Create an SQL query that finds all the information about the employees whose job title is "Sales Representative”.
SELECT * FROM Employees
WHERE [JobTitle] = 'Sales Representative'

--9 Create an SQL query to find the first name, last name, and job title for all employees whose salary is in a range between 20000 and 30000.
SELECT [FirstName], [LastName], [JobTitle] FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

--10 Create an SQL query that finds the full name of all employees whose salary is exactly 25000, 14000, 12500, or 23600. The result should be displayed in a column, named "Full Name", which is a combination of the first, middle, and last names separated by a single space.
SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name] FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

--11Create an SQL query that finds the first and last names of those employees who do not have a manager.
SELECT [FirstName], [LastName] FROM Employees
WHERE ManagerID is NULL

--12 Create an SQL query that finds the first name, last name, and salary for employees with a salary higher than 50000. Order the result in decreasing order by salary.
SELECT [FirstName], [LastName], [Salary] FROM Employees
WHERE Salary > 50000 
ORDER BY Salary DESC

--13 Create an SQL query that finds the first and last names of the 5 best-paid Employees, ordered descending by their salary.
SELECT TOP(5) [FirstName], [LastName] FROM Employees
ORDER BY Salary DESC

--14 Create an SQL query that finds the first and last names of all employees whose department ID is not 4.
SELECT [FirstName], [LastName] FROM Employees
WHERE DepartmentID != 4

/*15 Create an SQL query that sorts all the records in the Employees table by the following criteria:
•	By salary in decreasing order
•	Then by the first name alphabetically
•	Then by the last name descending
•	Then by middle name alphabetically */

SELECT * FROM Employees
ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC

--16 Create an SQL query that creates a view "V_EmployeesSalaries" with first name, last name, and salary for each employee.
CREATE VIEW V_EmployeesSalaries AS
SELECT [FirstName], [LastName], [Salary]
FROM Employees

SELECT * FROM V_EmployeesSalaries

--17
--CREATE TABLE EmployeeNameJobTitle
--(
--Id INT PRIMARY KEY IDENTITY,
--[Full Name] VARCHAR(50),
--[Job Title] VARCHAR(200)
--)

--INSERT INTO EmployeeNameJobTitle
--([Full Name], [Job Title])
--SELECT
--[FirstName] + ' ' + [LastName],
--[JobTitle]
--FROM Employees

--SELECT * FROM EmployeeNameJobTitle

--17 Create an SQL query that creates a view "V_EmployeeNameJobTitle" with a full employee name and a job title. When the middle name is NULL replace it with an empty string ('').
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT 
	[FirstName] + ' ' + ISNULL([MiddleName], '') + ' ' + [LastName] AS [Full Name],
	[JobTitle] AS [Job Title]
FROM [Employees]
 

 --18 Create an SQL query that finds all distinct job titles.
 SELECT DISTINCT JobTitle 
 FROM Employees

 --19 Create an SQL query that finds the first 10 projects which were started, select all the information about them, and order the result by starting date, then by name.
 SELECT TOP(10) * FROM Projects
 ORDER BY StartDate, [Name]

 --20 Create an SQL query that finds the last 7 hired employees, select their first, last name, and hire date. Order the result by hire date descending.
 SELECT TOP(7) FirstName, LastName, HireDate
 FROM Employees
 ORDER BY HireDate DESC

 -- 21Create an SQL query that increases salaries by 12% for all employees that work in one of the following departments - Engineering, Tool Design, Marketing, or Information Services. As a result, select and display only the "Salaries" column from the Employees table. After this, you should restore the database to the original data.

 UPDATE Employees
 SET Salary *= 1.12
 WHERE DepartmentID IN(1, 2, 4, 11)

 SELECT Salary
 FROM Employees

 --22 Display all the mountain peaks in alphabetical order.

 SELECT PeakName FROM Peaks
 ORDER BY PeakName

 --23 Find the 30 biggest countries by population, located in Europe. Display the "CountryName" and "Population". Order the results by population (from biggest to smallest), then by country alphabetically.

 SELECT TOP(30) CountryName, [Population]
 FROM Countries 
 WHERE [ContinentCode] = 'EU'
 ORDER BY [Population] DESC, CountryName

 SELECT * FROM Countries

 --24 Find all the countries with information about their currency. Display the "CountryName", "CountryCode", and information about its "Currency": either "Euro" or "Not Euro". Sort the results by country name alphabetically.
 SELECT CountryName, CountryCode, CASE WHEN CurrencyCode = 'EUR'
 THEN 'Euro'
 ELSE 'Not Euro'
 END AS [Currency]
 FROM Countries
 ORDER BY CountryName


 --25 Display all characters in alphabetical order.

 SELECT [Name] FROM Characters
 ORDER BY [Name]