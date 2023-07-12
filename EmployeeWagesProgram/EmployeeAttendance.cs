using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class employeeprogram
    {
        Random random = new Random();
        public void EmployeeWages()
        {
            
            int empCheck = random.Next(0, 2);


            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
        }
        const int wage_per_hour = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULL_TIME =0,IS_PART_TIME=1;
        int totalEmpWage = 0, empHrs = 0;

        public void calculateempwage()
        {
            int empCheck = random.Next(0, 3);
            if(empCheck == IS_FULL_TIME)
            {
                empHrs = FULL_DAY_HR;
            }
            if(empCheck == IS_PART_TIME)
            {
                empHrs = PART_DAY_HR;
            }
            totalEmpWage = wage_per_hour * empHrs;
           
            Console.WriteLine(totalEmpWage);
        }
    }
}
