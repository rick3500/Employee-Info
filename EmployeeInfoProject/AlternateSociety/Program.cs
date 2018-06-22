using AlternateSociety.Factory;
using AlternateSociety.Interface;
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
            // Here we use an interface to new up a typ
            Interface.IPerson mario = new Model.RaceCarDriver("Mario", "Cartman", "mario.cartman@email.com");
            Interface.IPerson flo = new Model.DenMother("Florence", "Henderson");

            // Now we can use a ServiceFactory to pass back a class rather than new it up locally.
            MakeARocketMan(ServiceFactory.CreateRocketMan("Apollo", "Fyve", "idiots@gmail.com"));

            //Interface.IPerson testDummy = personService.Create();

            // finish this or some other 
            //MakeASpaceMan(apollo);

            ImplementRaceCarDriver(mario);
            MakeADenMother(flo);

            Console.ReadLine();

        }

        private static void MakeARocketMan(IPerson apollo)
        {
            Console.WriteLine(apollo.Rest());
            Console.WriteLine(apollo.Awakens());
            
            Console.WriteLine(apollo.Speaks("I really don't care, do you?"));
            Console.WriteLine(apollo.Travels("The Earth", "The Moon"));
            Console.WriteLine(apollo.Rest());
            Console.WriteLine("\n\n");
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
