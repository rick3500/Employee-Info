using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Model
{
    public class Person : BasePerson
    {
     

        public Person(string firstName, string lastName, string email = "whoCares.com") : base(firstName, lastName, email)
        {
        }

        public new string Rest() { return "Resting..."; }

        public override string Travels(string startPoint, string endPoint)
        {
            return base.Travels(startPoint, endPoint);
        }

        public override string Speaks(string words)
        {
            return base.Speaks(words);
        }



    }
}
