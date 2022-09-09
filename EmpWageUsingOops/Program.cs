using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmpWageUsingOops.EmpWageBuilderArrayUC11;

namespace EmpWageUsingOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option 1.Checkattendence \t 2.Dailywage \t 3.Parttimewage \t 4.Empdailywage \t 5.wageformonth \t 6.Wages for month using whileloop \t 7.Refactorcode \t 8.EmpComapanywage \t 9.totalwageforeachcompany \t 10.ArrayCompany \t 11.IComputeEmpWage \t 13.totalwage \t 14.Final");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PresentAndAbsentUC1.CheckAttendence();
                    break;
                case 2:
                    DailyWageUC2.CalculateDailyWage();
                    break;
                case 3:
                    ParttimeWageUC3.CalculatePercentage();
                    break;
                case 4:
                    EmpSwitchCaseUC4.CalculateDailyWageswitch();
                    break;
                case 5:
                    MonthWagesUC5.CalculateWageForMonth();
                    break;
                case 6:
                    WagesForMonthUsingWhileLoopUC6.CalculateWage();
                    break;
                case 7:
                    RefactorCodeUC7.ComputEmpWage();
                    break;
                case 8:
                    EmpComputCompanyWagesUC8.CompanyWages("Jio mart", 30, 89, 90);
                    EmpComputCompanyWagesUC8.CompanyWages("Reliance", 56, 78, 89);
                    EmpComputCompanyWagesUC8.CompanyWages("BigBasket", 15, 45, 78);
                    break;
                case 9:
                    ToatalWageEachComapnyUC9 dmart = new ToatalWageEachComapnyUC9("Dmart", 30, 89, 45);
                    ToatalWageEachComapnyUC9 Reliance = new ToatalWageEachComapnyUC9("Reliance", 20, 65, 44);
                    dmart.computeEmpWage();
                    Console.WriteLine(dmart.toString());
                    Reliance.computeEmpWage();
                    Console.WriteLine(Reliance.toString());
                    break;
                case 10:
                    ArrayRefactorMultipleCompanyUC10 empWageBuilderArray = new ArrayRefactorMultipleCompanyUC10();

                    empWageBuilderArray.addCompanyEmpWage("Reliance", 67, 34, 45);
                    empWageBuilderArray.addCompanyEmpWage("jio mart", 89, 54, 29);
                    break;
                case 11:
                    EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                    empWageBuilder.AddCompanyEmpWage("D-Mart", 20, 20, 100);
                    empWageBuilder.AddCompanyEmpWage("Reliance", 20, 20, 100);
                    empWageBuilder.ComputeEmpWage();
                    break;
                 
                case 13:
                    DailyAndTotalWageUC13 totalwage1 = new DailyAndTotalWageUC13("Realiance", 45, 20, 15,30);
                    DailyAndTotalWageUC13 totalWage2 = new DailyAndTotalWageUC13("jio mart", 45, 30, 15,30);
                    totalwage1.computeEmpWage();
                    totalWage2.computeEmpWage();
                    break;
                case 14:
                    EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
                    employeeWageBuilder.AddCompanyEmpWage("D-Mart", 20, 2, 10);
                    employeeWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
                    employeeWageBuilder.ComputeEmpWage();
                    break;
                default:
                    Console.WriteLine("Enter wrong choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
