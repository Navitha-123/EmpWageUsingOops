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
            Console.WriteLine("Choose option 1.Checkattendence \t 2.Dailywage");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PresentAndAbsent.CheckAttendence();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
            }
            Console.ReadLine();
        }
    }
}
