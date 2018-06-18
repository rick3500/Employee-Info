using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject 
{
    public class PayInfo
    {
        /*Method returns individual pay rate matching employee ID passed in,
         back to the GetPay method of EmployeeInfo class*/

        public decimal MyPayInfo(int Eid)
        {
            decimal myPay;

            switch(Eid)
            {
                case 001:
                    myPay = 80000;
                    break;
              
                case 002:
                    myPay = 80000;
                    break;
                   
                case 003:
                    myPay = 55000;
                    break;

                case 004:
                    myPay = 48500;
                    break;

                case 011:
                    myPay = 18.00M;
                    break;

                case 012:
                    myPay = 15.50M;
                    break;

                case 013:
                    myPay = 22.75M;
                    break;

                case 014:
                    myPay = 18.00M;
                    break;

                default:
                    return 0;
                        
                
            }

            return myPay;
            
        }
    }
}
