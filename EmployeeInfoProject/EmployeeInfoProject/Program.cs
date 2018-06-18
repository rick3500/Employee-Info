using System;
using System.Collections.Generic;

namespace EmployeeInfoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calls the EmployeeInfo class to run the employee data requested
            EmployeeInfo ei = new EmployeeInfo();

            ei.MyList();

            Console.ReadLine();
        }
    }
}
