using System;

namespace UC2_Calculate_Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            ////constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            ////variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            switch(empCheck)
            {
                case 0: empHrs = 8;
                case 1; empHrs = 8;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empWage);
        }
    }
}