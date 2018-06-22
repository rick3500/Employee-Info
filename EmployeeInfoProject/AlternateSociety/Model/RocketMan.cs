using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Model
{
    public class RocketMan : BasePerson
    {
        public RocketMan(string firstName, string lastName, string email = "whoCares.com") : base(firstName, lastName, email)
        {
        }

        // here you 'hide' the original Rest function and implement your own
        public new string Rest()
        {
            return $"Captain {LastName} pulled the visor down on his helment and began to snore loudly";
        }

        public override string Travels(string startPoint, string endPoint)
        {
            // if you unremark the "return base.Travels(startPoint, endPoint)" line and remark out anything
            // added here, it will have the effect of calling the BasePerson method.

            //return base.Travels(startPoint, endPoint);
            return $"Then Captain {LastName} climbed into the capsule atop the sleek rocket ship and blasted off from {startPoint} on the way to {endPoint}!";
        }

        public override string Speaks(string words)
        {
            return base.Speaks(words);
        }
    }
}
