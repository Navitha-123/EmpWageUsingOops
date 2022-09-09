using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    public class EmpComputCompanyWagesUC8
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static void CompanyWages(string company,int EmpRatePerHour,int NumOfWorkingDays,int MaxHrsPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < MaxHrsPerMonth && totalWorkingDays <= NumOfWorkingDays)
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
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day {0} and empHrs {1} total empHrs {2}", totalWorkingDays, empHrs, totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total emp wage for company : " + company + " is: " + totalEmpWage);
          

        }
    }
}
