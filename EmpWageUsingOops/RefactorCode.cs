using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class RefactorCode
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static void ComputEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);//0,1,2
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                        empHrs = 8;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;//totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day {0} and empHrs {1}  total empHrs {2}", totalWorkingDays, totalEmpHrs, empHrs);

            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total emp wage is:{0}  ", +totalEmpWage);
        }

    }



}

