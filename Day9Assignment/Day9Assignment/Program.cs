using System;

namespace Day9Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RefactorEmpWage employeeWage = new RefactorEmpWage();

            employeeWage.GetEmployeeWage("HCL", 20, 100, 20);
        }
    }
}