using AlternateSociety.Interface;
using AlternateSociety.Model;
//using AlternateSociety.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateSociety.Factory
{
    public static class ServiceFactory
    {
        //public static IPersonService CreatePersonService()
        //{
        //    return new PersonService();
        //}

        //public static IPersonService CreateRaceCarDriverService()
        //{
        //    return new RaceCarDriverService();
        //}

        //public static IPersonService CreateDenMotherService()
        //{
        //    return new DenMotherService();
        //}

        public static IPerson CreateRocketMan(string firstName, string lastName, string email)
        {
            return new RocketMan(firstName, lastName, email);
        }
    }
}
