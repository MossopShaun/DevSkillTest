using BookingGatewayService.Tests.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingGatewayService.Tests
{
    [TestClass]
    public class BookingGatewayFactoryTest
    {
        [TestMethod]
        public void CheckIsBookingGatewayImplemented()
        {
            Assert.IsNotNull(BookingGatewayFactory.CreateGateway(new FakeDBRepository()));
        }

        [TestMethod]
        public void CheckIsDBRepositorySetInBookingGateway()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            Assert.IsNotNull(gateway.DBRepository);
            Assert.AreEqual(fakeDB, gateway.DBRepository);
        }
    }
}
