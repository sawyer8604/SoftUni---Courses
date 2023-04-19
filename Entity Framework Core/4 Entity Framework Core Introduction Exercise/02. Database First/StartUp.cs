using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();

            string result = RemoveTown(dbContext);
            Console.WriteLine(result);
        }

        // problem 03 Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        //problem 04 Employees with Salary Over 50 000

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.FirstName)
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                }
                )
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        // problem 05 Employees from Research and Development
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {

            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                }
                )
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
            }

            return result.ToString().TrimEnd();
        }


        // problem 06 Adding a New Address and Updating Employee

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            Address newAdres = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(newAdres);

            Employee nakov = context.Employees
                .First(e => e.LastName == "Nakov");

            nakov.Address = newAdres;

            context.SaveChanges();

            var employees = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => new
                {
                    adressText = e.Address.AddressText
                }
                )
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine(e.adressText);
            }

            return result.ToString().TrimEnd();
        }

        // problem 07 AddNewAddressToEmployee

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {

            StringBuilder result = new StringBuilder();

            var employeesWithProject = context.Employees
                .Where(e => e.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Take(10)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    AllProjects = e.EmployeesProjects
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                        StarDate = ep.Project.StartDate,
                        EndDate = ep.Project.EndDate
                    })
                    .ToArray()
                })
                .ToArray();

            foreach (var e in employeesWithProject)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");

                foreach (var p in e.AllProjects)
                {
                    var startDate = p.StarDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    var endDate = p.EndDate.HasValue ? p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) : "not finished";

                    result.AppendLine($"--{p.ProjectName} - {startDate} - {endDate}");
                }
            }

            return result.ToString().TrimEnd();
        }

        // problem 08. Addresses by Town

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var adresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(t => t.Town.Name)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .Select(a => new
                {
                    a.AddressText,
                    a.Town.Name,
                    a.Employees.Count
                })
                .ToArray();

            foreach (var a in adresses)
            {
                result.AppendLine($"{a.AddressText} {a.Name} - {a.Count} employees");
            }

            return result .ToString().TrimEnd();
        }

        // problem 09. 

        public static string GetEmployee147(SoftUniContext context)
        {

            StringBuilder result = new StringBuilder();

            var employees147 = context.Employees
                .Where(e => e.AddressId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    AllProjects = e.EmployeesProjects
                    .Select(ep => new
                    {
                        projectName = ep.Project.Name
                    })
                    .ToArray()
                })
                .ToArray();

            foreach (var e in employees147)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");

                foreach (var p in e.AllProjects)
                {
                    result.AppendLine($"{p.projectName}");
                }
            }

            return result.ToString().TrimEnd();
        }

        // problem 10

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {

            StringBuilder result = new StringBuilder();

            var department = context.Departments
                .Where(e => e.Employees.Count > 5)
                .OrderBy(e => e.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                { 
                    d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    Employees = d.Employees
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.JobTitle
                    })
                    .ToArray()
                })
                .ToArray();

            foreach (var d in department)
            {
                result.AppendLine($"{d.Name} - {d.ManagerFirstName}  {d.ManagerLastName}");

                foreach (var e in d.Employees.OrderBy(fn => fn.FirstName).ThenBy(ln => ln.LastName))
                {
                    result.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }
            }

            return result.ToString().TrimEnd();
        }

        // problem  11. Find Latest 10 Projects

        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var lastestProjects = context.Projects
                .OrderByDescending(p => p.StartDate)                
                .Take(10)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate

                })
                .ToArray();

            foreach (var p in lastestProjects)
            {
                result.AppendLine(p.Name);
                result.AppendLine(p.Description);
                result.AppendLine(p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return result.ToString().TrimEnd();
        }

        // problem 12. Increase Salaries

        public static string IncreaseSalaries(SoftUniContext context)
        {

            StringBuilder result = new StringBuilder();

            decimal salaryModifier = 1.12m;
            string[] departmentNames = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };

            var employeesForSalaryIncrease = context.Employees
                .Where(e => departmentNames.Contains(e.Department.Name))
                .ToArray();

            foreach (var e in employeesForSalaryIncrease)
            {
                e.Salary *= salaryModifier;
            }

            context.SaveChanges();

            string[] emplyeesInfoText = context.Employees
                .Where(e => departmentNames.Contains(e.Department.Name))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => $"{e.FirstName} {e.LastName} (${e.Salary:f2})")
                .ToArray();

            foreach (var e in emplyeesInfoText)
            {
                result.AppendLine(e);
            }

            return result.ToString().TrimEnd();
        }

        // problem 13. Find Employees by First Name Starting With Sa

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employeesStartingWithSa = context.Employees
                .Where(e => e.FirstName.ToLower().StartsWith("sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();

            foreach (var e in employeesStartingWithSa)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }

            return result.ToString().TrimEnd();
        }

        // problem 14. Find Employees by First Name Starting With Sa

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            Project projectToDelete = context.Projects.Find(2);

            EmployeeProject[] referdEmployees = context.EmployeesProjects
                .Where(ep => ep.ProjectId == projectToDelete.ProjectId)
                .ToArray();

            context.EmployeesProjects.RemoveRange(referdEmployees);

            context.Projects.Remove(projectToDelete);

            context.SaveChanges();

            string[] projectNames = context
                .Projects
                .Take(10)
                .Select(p => p.Name)
                .ToArray();

            foreach (var name in projectNames)
            {
                result.AppendLine(name);
            }

            return result.ToString().TrimEnd();

        }

        // problem 15 Remove Town

        public static string RemoveTown(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            Town townToDelete = context.Towns
                .Where(t => t.Name == "Seattle")
                .FirstOrDefault();

            Address[] addressesToDelete = context.Addresses
                .Where(a => a.TownId == townToDelete.TownId)
                .ToArray();

            Employee[] employeesToRemoveAddressFrom = context.Employees
                .Where(e => addressesToDelete
                .Contains(e.Address))
                .ToArray();

            foreach (Employee e in employeesToRemoveAddressFrom)
            {
                e.AddressId = null;
            }

            context.Addresses.RemoveRange(addressesToDelete);

            context.Towns.Remove(townToDelete);

            context.SaveChanges();

            result.AppendLine($"{addressesToDelete.Count()} addresses in Seattle were deleted");

            return result.ToString().TrimEnd();
        }
    }
}
