using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Assignment
{
    internal class EmployeeWage
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation  Program on Master Branch");
        }

        public static void GetAttendance()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            CheckAttendance(number);
        }

        public static void CheckAttendance(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
    }
}