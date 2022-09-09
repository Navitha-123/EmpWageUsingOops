using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmpWageUsingOops.EmpWageBuilderArrayUC11;

namespace EmpWageUsingOops
{
    public class TotalWageUC13
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int EmpRatePerHour;
        private int NumOfWorkingDay;
        private int MaxHourPerMonth;
        private int totalEmpWage;


        public TotalWageUC13(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth, int totalEmpWage)
        {
            this.company = company;
            this.EmpRatePerHour = empRatePerHour;
            this.NumOfWorkingDay = numOfWorkingDay;
            this.MaxHourPerMonth = maxHourPerMonth;
            this.totalEmpWage = totalEmpWage;
        }

        public void computeEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs<=this.MaxHourPerMonth && totalWorkingDays < this.NumOfWorkingDay)
            {
                totalWorkingDays++;
                int EmpWage;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        EmpWage = empHrs * EmpRatePerHour;
                        break;
                    case2:
                        empHrs = 8;
                        EmpWage = empHrs * EmpRatePerHour;
                        break;
                    default:
                        empHrs = 0;
                        EmpWage = empHrs * EmpRatePerHour;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Employee hours : " + empHrs + " Daily Wage : " + EmpWage);

            }
            totalEmpWage = totalEmpHrs + EmpRatePerHour;
            Console.WriteLine("Total employee wage for company : " + company + " is : " + totalEmpWage);

        }
    }
}
