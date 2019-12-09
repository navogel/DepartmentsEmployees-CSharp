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

            var employeeRepo = new EmployeeRepository();

            List<Employee> allEmployees = employeeRepo.GetAllemployees();

            foreach (Employee person in allEmployees)
            {
                Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName} working in {person.DeptName}");
            }

            var employee1 = employeeRepo.GetEmployeeById(1);
            Console.WriteLine(".............................");
            Console.WriteLine($"Employee with Id 1 is {employee1.FirstName} {employee1.LastName} works in {employee1.DeptName}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //ADDING UPDATING DEPTS

            //var newDept = new Department();

            //Console.WriteLine("What dept would you like to add?");

            //newDept.DepartmentName = Console.ReadLine();

          
            //departmentRepo.AddDepartment(newDept);

            //Console.WriteLine("what Dept Id to change?");
            //var deptToUpdate = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("what to call it?");
            //var newDeptName = Console.ReadLine();

            

            //departmentRepo.UpdateDepartment(deptToUpdate, new Department { DepartmentName = newDeptName });

            //delete department

            //departmentRepo.DeleteDepartment(1);

            //ADDING NEW EMPLOYEE

            employeeRepo.AddEmployee(new Employee { FirstName = "jojo", LastName = "bob", DepartmentId = 1 });
        }
    }
}
