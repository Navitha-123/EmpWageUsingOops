using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    public class ArrayRefactorMultipleCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public ArrayRefactorMultipleCompany()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string Company,int  EmpRatePerHour,int  NumOfWorkingDay,int MaxHourPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(Company, EmpRatePerHour, NumOfWorkingDay, MaxHourPerMonth);
            numOfCompany++;
        }

        public void EmpWageCompute()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.EmpWageCompute(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int EmpWageCompute(CompanyEmpWage EmpWageCompany)
        {
            //variable
            int empHrs = 0, totalEmpHrs = 0, totalWorkinDays = 0;
            //computation
            while (totalEmpHrs <= EmpWageCompany.maxHourPerMonth && totalWorkinDays < EmpWageCompany.numOfWorkinDay)
            {
                totalWorkinDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkinDays + " Employee hours : " + empHrs);
            }
            return totalEmpHrs * EmpWageCompany.empRatePerHour;
        }
    }

    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkinDay;
        public int maxHourPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDay, int MaxHourPerMonth)
        {
            this.company = Company;
            this.empRatePerHour = EmpRatePerHour;
            this.numOfWorkinDay = NumOfWorkingDay;
            this.maxHourPerMonth = MaxHourPerMonth;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Employee wage for company : " + this.company + " is : " + this.totalEmpWage;
        }

    }
}
   
