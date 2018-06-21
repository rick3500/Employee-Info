using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Model
{
    public class RaceCarDriver : BasePerson
    {
        public RaceCarDriver(string firstName, string lastName, string email = "whoCares.com") : base(firstName, lastName, email)
        {
        }

        // here you 'hide' the original Rest function and implement your own
        public new string Rest()
        {
            return $"{FirstName} crawled upon the bed, fluffed the pillow and went to dreamland";
        }

        public override string Travels(string startPoint, string endPoint)
        {
            // if you unremark the next line and remark out anything
            // added here, it will have the effect of calling the BasePerson
            // method.
            //return base.Travels(startPoint, endPoint);
            return $"{FirstName} jumped into his race car, slammed it into first gear and sped from {startPoint} to {endPoint} at a great rate of speed!";
        }

        public override string Speaks(string words)
        {
            return base.Speaks(words);
        }
    }
}
