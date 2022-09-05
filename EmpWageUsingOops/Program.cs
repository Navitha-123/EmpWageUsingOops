using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option 1.Checkattendence \t 2.Dailywage \t 3.Parttimewage \t 4.Empdailywage \t 5.wageformonth \t 6.Wages for month using whileloop \t 7.Refactorcode");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PresentAndAbsent.CheckAttendence();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    ParttimeWage.CalculatePercentage();
                    break;
                case 4:
                    EmpSwitchCase.CalculateDailyWageswitch();
                    break;
                case 5:
                    MonthWages.CalculateWageForMonth();
                    break;
                case 6:
                    WagesForMonthUsingWhileLoop.CalculateWage();
                    break;
                case 7:
                    RefactorCode.ComputEmpWage();
                    break;
                default:
                    Console.WriteLine("Enter wrong choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
