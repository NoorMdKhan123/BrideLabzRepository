using System;

namespace EmployeeWageuC3
{
    /// <summary>

    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            
            const int is_Part_Time = 1;
            const int is_Full_Time = 2;
            const int empWagePerHour = 10;
            const int empNofWrkngDays = 20;
           
            int empHr = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            

            
            for (int days = 0; days < empNofWrkngDays; days++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == is_Part_Time)
                {
                    empHr = 4;
                }
                else if (empCheck == is_Full_Time)
                {
                    empHr = 8;
                }
                else
                {
                    empHr = 0;
                }
                empWage = empHr * empWagePerHour;
                Console.WriteLine("employee one day wage is" + empWage);
                totalEmpWage += empWage;
                
            }
            Console.WriteLine("Total emp wage:" + totalEmpWage);
           

        }




    }
}
