using System;

namespace EmployeeWage
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>  
          static void Main(string[] args)
        {
            ///

            int employee = 1;
            int employeeWage = 0;
            if (employee == 1)
            {
                employeeWage = 200 * 12;
                Console.WriteLine("Employee wage of 12 hours is" + employeeWage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
