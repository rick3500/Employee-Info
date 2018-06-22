using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Model
{
    public abstract class BasePerson : Interface.IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public BasePerson(string firstName, string lastName, string email = "whoCares.com")
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string Rest()
        {
            return "Sleeps";
        }

        public string Awakens()
        {
            return "Awakens, Yawns and ";
        }
        public virtual string Speaks(string words)
        {
            return $"{FirstName} says {words}";
        }

        public virtual string Travels(string startPoint, string endPoint)
        {
            return $"{FirstName} walked from {startPoint} to {endPoint}";
        }
    }
}
