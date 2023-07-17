using EmployeeWagesProgram;
using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage problem");

            employeeprogram e = new employeeprogram("apple", 100, 20, 100);
            e.EmployeeWages();
            e.calculateempwage();

            employeeprogram a = new employeeprogram("Amazon", 150, 30, 120);
            e.EmployeeWages();
            e.calculateempwage();

        }
    }
}