using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class employeeprogram
    {
        const int FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1;
        int totalEmpWage = 0, empHr = 0, WagePerHr, totalWorkingDays, totalWorkingHrs;
        string CompanyName;
        Random random = new Random();
        public employeeprogram(string CompanyName, int WagePerHr, int totalWorkingDays, int totalWorkinghrs)
        {
            this.CompanyName = CompanyName;
            this.WagePerHr = WagePerHr;
            this.totalWorkingDays = totalWorkingDays;
            this.totalWorkingHrs = totalWorkinghrs;
        }
        public void EmployeeWages()
        {
            
            int empCheck = random.Next(0, 2);


            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
        }
        const int wage_per_hour = 20, TOTAL_WORKING_DAYS=20, TOTAL_WORKING_HRS=100;
        int  empHrs = 0;

        public void calculateempwage()
        {

            for(int i = 0;i < TOTAL_WORKING_DAYS && empHrs<TOTAL_WORKING_HRS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck){
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_DAY_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }

           
           
            totalEmpWage = wage_per_hour * empHrs;
           
            Console.WriteLine(totalEmpWage);
        }
    }
}
