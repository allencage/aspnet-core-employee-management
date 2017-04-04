using Microsoft.EntityFrameworkCore;
using Repo.EF;
using System;
using System.Collections.Generic;
using DataModels = Repo.EF.Models;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var dbContextOptions = new DbContextOptionsBuilder();
            dbContextOptions.UseInMemoryDatabase();
            using(var db = new DataContext(dbContextOptions.Options))
            {
                var genericRepo = new GenericRepo<DataModels.Employee>(db);
                var employeeList = new List<DataModels.Employee>
                {
                    new DataModels.Employee
                    {
                        FirstName = "Alin",
                        LastName = "Ciuca",
                        Status = new DataModels.Status
                        {
                            EmploymentType = DataModels.DataManager.EmploymentType.FullTime,
                            HireDate = DateTime.Now,
                            IsHired = true,
                        }
                    },
                    new DataModels.Employee
                    {
                        FirstName = "Alin",
                        LastName = "Ciuca",
                        Status = new DataModels.Status
                        {
                            EmploymentType = DataModels.DataManager.EmploymentType.FullTime,
                            HireDate = DateTime.Now,
                            IsHired = true,
                        }
                    },
                    new DataModels.Employee
                    {
                        FirstName = "Alin",
                        LastName = "Ciuca",
                        Status = new DataModels.Status
                        {
                            EmploymentType = DataModels.DataManager.EmploymentType.FullTime,
                            HireDate = DateTime.Now,
                            IsHired = true,
                        }
                    }

                };

                genericRepo.AddRange(employeeList);
                genericRepo.Commit();

                var allEmployees = genericRepo.GetAll();

                foreach (var item in allEmployees)
                {
                    DisplayData(item);
                }

            }
            Console.Read();
        }

        public static void DisplayData(DataModels.Employee repoEmp)
        {
            Console.WriteLine(repoEmp.Id);
            Console.WriteLine(repoEmp.FirstName);
            Console.WriteLine(repoEmp.LastName);
            Console.WriteLine(repoEmp.Status.EmployeeId);
            Console.WriteLine(repoEmp.Status.HireDate);
            Console.WriteLine(repoEmp.Status.IsHired);
            Console.WriteLine(repoEmp.Status.EmploymentType);
        }
    }
}