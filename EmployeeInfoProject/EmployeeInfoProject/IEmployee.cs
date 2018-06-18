using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    public interface IEmployee
    {
        int Eid { get; set; }
        string Status { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Department { get; set; }

        void GetPayInfo(decimal basePay);
    }
}
