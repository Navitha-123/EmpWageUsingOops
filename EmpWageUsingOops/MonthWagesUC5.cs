using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class MonthWagesUC5
    {
        public static void CalculateWageForMonth()
        {
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 1; day < 20; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(1, 3);//1,2

                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;//totalEmpWage=totalEmpWage+empWage
                Console.WriteLine("daily emp wage is {0} total emp wage {1}", empWage, totalEmpWage);
            }
            Console.WriteLine("Total emp wage is: " + totalEmpWage);
        }


    }
}
    

