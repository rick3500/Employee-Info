using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Model
{
    public class DenMother : BasePerson
    {
        public DenMother(string firstName, string lastName, string email = "whoCares.com") : base(firstName, lastName, email)
        {
        }

        // here you 'hide' the original Rest function and implement your own
        public new string Rest()
        {
            return $"{FirstName} drew back the sheet and sank her head into the pillow.";
        }

        public override string Travels(string startPoint, string endPoint)
        {
            // if you unremark the next line and remark out anything
            // added here, it will have the effect of calling the BasePerson
            // method.
            //return base.Travels(startPoint, endPoint);
            return $"{FirstName} jumped into her minivan pulled out of her {startPoint} and drove to {endPoint} with kids in tow!";
        }

        public override string Speaks(string words)
        {
            return base.Speaks(words);
        }
    }
}
