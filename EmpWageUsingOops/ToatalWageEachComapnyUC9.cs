using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    public class ToatalWageEachComapnyUC9
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int emprateperhour;
        private int numofworkingday;
        private int maxhourpermonth;
        private int totalEmpWage;

        public ToatalWageEachComapnyUC9(string company, int emprateperhour, int numofworkingday, int maxhourpermonth)
        {
            this.company = company;
            this.emprateperhour = emprateperhour;
            this.numofworkingday = numofworkingday;
            this.maxhourpermonth = maxhourpermonth;
        }

        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < maxhourpermonth && totalWorkingDays <= numofworkingday)
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
                Console.WriteLine("Day {0} and empHrs {1} ", totalWorkingDays, empHrs);
            }
            int totalEmpWage = totalEmpHrs * this.emprateperhour;
            Console.WriteLine("Total emp wage for company : " + company + " is: " + totalEmpWage);
        }

        public string toString()
        {
            return "Total Emp Wage For Company : " + this.company + "is :" + this.totalEmpWage;
        }

        
    }
}
