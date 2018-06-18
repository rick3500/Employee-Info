using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    public class EmployeeInfo 
    {
        Hourly hy = new Hourly();
        Salaried sy = new Salaried();
        List<IEmployee> employee = new List<IEmployee>();
        PayInfo myPayInfo = new PayInfo();

        public void MyList()
        {
            employee.Add(new Hourly { FirstName = "Bob", LastName = "Smith", Email = "B.Smith@company.com", Department = "Intern IT", Eid = 11, Status = "hr" });
            employee.Add(new Hourly { FirstName = "Carla", LastName = "Davis", Email = "C.Davis@company.com", Department = "Admin Assistant", Eid = 12, Status = "hr" });
            employee.Add(new Hourly { FirstName = "Terry", LastName = "Owens", Email = "T.Owens@company.com", Department = "IT specialist tech" , Eid = 13,Status = "hr"});
            employee.Add(new Hourly { FirstName = "Tim", LastName = "Jones", Email = "T.Jones@company.com", Department = "Intern IT", Eid= 14, Status = "hr" });

            employee.Add(new Salaried { FirstName = "Will", LastName = "Smith", Email = "W.Smith@company.com", Department = "Co Owner / CEO" , Eid = 01,Status = "sy" });
            employee.Add(new Salaried { FirstName = "Miriam", LastName = "Davis", Email = "M.Davis@company.com", Department = "Accounting ", Eid = 04 ,Status = "sy" });
            employee.Add(new Salaried { FirstName = "Polly", LastName = "Jones", Email = "P.Jones@company.com", Department = "Marketing / CFO", Eid = 03 , Status = "sy" });
            employee.Add(new Salaried { FirstName = "Sam", LastName = "Young", Email = "S.Young@company.com", Department = "Co Owner / CTO", Eid = 02, Status = "sy" });

            foreach (IEmployee emp in employee)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}   Email: {emp.Email}  Department: {emp.Department}");

                if (emp is Salaried)
                {
                    GetPayInfo(sy, myPayInfo.MyPayInfo(emp.Eid));
                }
                else
                {
                    GetPayInfo(hy, myPayInfo.MyPayInfo(emp.Eid));
                }
                Console.WriteLine(" ");
            }

        }

        static void GetPayInfo(IEmployee emp, decimal basePay)
        {
            emp.GetPayInfo(basePay);
        }
    }
}
