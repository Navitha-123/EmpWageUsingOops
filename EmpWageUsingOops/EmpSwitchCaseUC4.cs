using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class EmpSwitchCaseUC4
    {
        public static void CalculateDailyWageswitch()
        {
            //const int IS_FULL_TIME = 1;
            // const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empcheck = random.Next(1, 3);//1,2
            switch (empcheck)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee daily wage inluding part time is " + empWage);
        }

    }
}

