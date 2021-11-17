﻿// See https://aka.ms/new-console-template for more information

using FactoryPattern.BL.Employees.Abstract;
using FactoryPattern.BL.Factories.Employees;

Console.Write("Enter employee name: ");
var inputName = Console.ReadLine();

Console.Write("Enter employee salary: ");
var inputSalary = Console.ReadLine();
int.TryParse(inputSalary, out int salary);

Console.WriteLine("Select the employee type:");
Console.WriteLine("1: Developer");
Console.WriteLine("2: Manager");
Console.WriteLine("3: Plumber");
var inputEmployeeType = Console.ReadLine();
EmployeeType.TryParse(inputEmployeeType, out EmployeeType employeeType);

IEmployeeFactory employeeFactory = new EmployeeFactory(inputName, salary);
IEmployee employee = employeeFactory.Create(employeeType);

Console.WriteLine(employee.Name + " " + employee.Salary);
employee.Work();