using DepartmentsEmployees.Data;
using DepartmentsEmployees.Models;
using System;
using System.Collections.Generic;

namespace DepartmentsEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            var departmentRepo = new DepartmentRepository();

            

            Console.WriteLine("Getting All Departments:");
            Console.WriteLine();

            List<Department> allDepartments = departmentRepo.GetAllDepartments();

            foreach (Department dept in allDepartments)
            {
                Console.WriteLine($"{dept.Id} {dept.DepartmentName}");
            }

            var hardCodedId = 3;
            var departmentWithId3 = departmentRepo.GetDepartmentById(hardCodedId);
            Console.WriteLine(".............................");
            Console.WriteLine($"Department with Id {hardCodedId} is {departmentWithId3.DepartmentName}");

        }
    }
}
