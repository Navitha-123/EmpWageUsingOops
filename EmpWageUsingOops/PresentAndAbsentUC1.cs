using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    internal class PresentAndAbsentUC1
    {
        public static void CheckAttendence()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
                
        }
    }
}
