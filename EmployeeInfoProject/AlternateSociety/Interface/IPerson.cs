using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Interface
{
    public interface IPerson
    {
        string Travels(string startPoint, string endPoint);
        string Speaks(string words);
        string Rest();
        string Awakens();
    }
}
