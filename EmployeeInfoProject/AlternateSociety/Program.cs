using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface.IPerson mario = new Model.RaceCarDriver("Mario", "Cartman", "mario.cartman@email.com");
            Interface.IPerson flo = new Model.DenMother("Florence", "Henderson");

            // finish this or some other 
            //MakeASpaceMan(apollo);



            ImplementRaceCarDriver(mario);
            MakeADenMother(flo);

            Console.ReadLine();

        }

        private static void MakeADenMother(Interface.IPerson flo)
        {
            Console.WriteLine(flo.Rest());
            Console.WriteLine(flo.Awakens());
            Console.WriteLine(flo.Speaks("Come on KIDS we have to go NOW!"));
            Console.WriteLine(flo.Travels("Driveway", "School house"));
            Console.WriteLine("\n\n");
        }

        private static void ImplementRaceCarDriver(Interface.IPerson mario)
        {
            Console.WriteLine(mario.Rest());
            Console.WriteLine(mario.Awakens());
            Console.WriteLine(mario.Speaks("Hello Gary, it is nice to meet you! Would you like to play a game?"));
            Console.WriteLine(mario.Travels("Pit Stop", "Finish Line"));
            Console.WriteLine("\n\n");
        }
    }
}
