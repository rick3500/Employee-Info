using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlternateSociety.Test
{
    [TestClass]
    public class ServiceFactoryTest
    {
        [TestMethod]
        public void ServiceFactoryCanCreatePersonService()
        {
            var personService = Factory.ServiceFactory.CreatePersonService();
            Assert.IsInstanceOfType(personService,typeof(Service.PersonService));
        }

        [TestMethod]
        public void ServiceFactoryCanCreateRaceCarDriverService()
        {
            var raceCarDriverService = Factory.ServiceFactory.CreateRaceCarDriverService();
            Assert.IsInstanceOfType(raceCarDriverService, typeof(Service.RaceCarDriverService));
        }

        [TestMethod]
        public void ServiceFactoryCanCreateDenMotherService()
        {
            var denMotherService = Factory.ServiceFactory.CreateDenMotherService();
            Assert.IsInstanceOfType(denMotherService, typeof(Service.DenMotherService));
        }
    }
}
