using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{ 
    //Creates and prints Employees Info of both Salary and Hourly status
    public class EmployeeInfo 
    {
        Hourly hy = new Hourly();
        Salaried sy = new Salaried();
        List<IEmployee> employee = new List<IEmployee>();
        PayInfo myPayInfo = new PayInfo();

        public void MyList()
        {
            employee.Add(new Hourly { FirstName = "Bob", LastName = "Smith", Email = "B.Smith@company.com", Department = "Intern IT", EID = 11 });
            employee.Add(new Hourly { FirstName = "Carla", LastName = "Davis", Email = "C.Davis@company.com", Department = "Admin Assistant", EID = 12});
            employee.Add(new Hourly { FirstName = "Terry", LastName = "Owens", Email = "T.Owens@company.com", Department = "IT specialist tech" , EID = 13});
            employee.Add(new Hourly { FirstName = "Tim", LastName = "Jones", Email = "T.Jones@company.com", Department = "Intern IT", EID= 14});

            employee.Add(new Salaried { FirstName = "Will", LastName = "Smith", Email = "W.Smith@company.com", Department = "Co Owner / CEO" , EID = 01});
            employee.Add(new Salaried { FirstName = "Miriam", LastName = "Davis", Email = "M.Davis@company.com", Department = "Accounting ", EID = 04 });
            employee.Add(new Salaried { FirstName = "Polly", LastName = "Jones", Email = "P.Jones@company.com", Department = "Marketing / CFO", EID = 03 });
            employee.Add(new Salaried { FirstName = "Sam", LastName = "Young", Email = "S.Young@company.com", Department = "Co Owner / CTO", EID = 02 });

            foreach (IEmployee emp in employee)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}   Email: {emp.Email}  Department: {emp.Department}");
                
                //Calls GetPay method below that takes in (as a Parameter) a call to PayInfo class for specific info based on employee ID
                if (emp is Salaried)
                {
                    GetPayInfo(sy, myPayInfo.MyPayInfo(emp.EID));
                }
                else
                {
                    GetPayInfo(hy, myPayInfo.MyPayInfo(emp.EID));
                }
                Console.WriteLine(" ");
            }

        }
        /*This method uses the proper class Implimentation of Getpay() based on class - hourly/salaried  
        Takes in returned pay info from PayInfo class*/
        static void GetPayInfo(IEmployee emp, decimal basePay)
        {
            emp.GetPayInfo(basePay);
        }
    }
}
