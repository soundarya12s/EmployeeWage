using EmployeeWagesProgram;
using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage problem");

            employeeprogram e = new employeeprogram();
            e.EmployeeWages();
            e.calculateempwage();

        }
    }
}