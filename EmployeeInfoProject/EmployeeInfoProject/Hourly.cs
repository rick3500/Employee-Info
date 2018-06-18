using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    public class Hourly : IEmployee
    {
        public string Status { get; set; }
        public int Eid { get; set; }

        public string FirstName { get ; set ; }
        public string LastName { get ; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public void GetPayInfo(decimal basePay)
        {
            Console.WriteLine("Employees pay rate is $ " + basePay + " per hour.");
        }
    }
}
