using BookingGatewayService.Exceptions;
using BookingGatewayService.Tests.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BookingGatewayService.Tests
{
    [TestClass]
    public class BookingGatewayTest
    {
        /// <summary>
        /// Check is StartBooking implemented
        /// </summary>
        [Timeout(5000)]
        [TestMethod]
        public void StartBookingImplementationTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            gateway.StartBooking();
            gateway.EndBooking();
        }

        /// <summary>
        /// Check is EndBooking implemented
        /// </summary>
        [Timeout(5000)]
        [TestMethod]
        public void EndBookingImplementationTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            gateway.StartBooking(); // must be called before EndBooking
            gateway.EndBooking();
            Assert.ThrowsException<NoStartBookingException>(() => gateway.EndBooking()); // try end again...
        }

        /// <summary>
        /// Check is EndBooking implemented
        /// </summary>
        [Timeout(5000)]
        [TestMethod]
        public void EndBookingBeforeStartBookingImplementationTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            Assert.ThrowsException<NoStartBookingException>(() => gateway.EndBooking()); // try end before start
        }

        /// <summary>
        /// Check is EndBooking implemented
        /// </summary>
        [Timeout(5000)]
        [TestMethod]
        public void CheckBookingTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);

            gateway.StartBooking(); // must be called before EndBooking
            try
            {
                gateway.Booking("ref1", 100, "title", "123", "456");
                gateway.Booking("ref2", 200, "title 2", "123", "456");
                gateway.GetBookingStatuses(new List<string>() { "noneRef" });
            }
            finally
            {
                gateway.EndBooking();
            }
            Assert.AreEqual(2, fakeDB.Data.Count);
        }

        /// <summary>
        /// Check is GetBookingStatuses implemented
        /// </summary>
        [Timeout(5000)]
        [TestMethod]
        public void CheckGetBookingStatusesTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);

            gateway.StartBooking();
            try
            {
                gateway.Booking("ref1", 100, "title", "123", "456");
                gateway.Booking("ref2", 200, "title 2", "123", "456");
            }
            finally
            {
                gateway.EndBooking();
            }
            var statuses = gateway.GetBookingStatuses(new List<string>() { "ref1", "ref2" }); // must be called before EndBooking
            Assert.AreEqual(2, statuses.Count);
        }

        /// <summary>
        /// Check are data correctly saved.
        /// </summary>
        [Timeout(5000)]
        [TestMethod]
        public void CheckBookingDataTest()
        {
            var fakeDB = new FakeDBRepository();
            var gateway = BookingGatewayFactory.CreateGateway(fakeDB);
            Assert.IsNotNull(gateway);
            Assert.AreEqual(0, fakeDB.Data.Count);

            gateway.StartBooking();
            try
            {
                gateway.Booking("ref1", 100m, "title", "123", "456");
                gateway.Booking("ref2", 200m, "title 2", "123", "456");
            }
            finally
            {
                gateway.EndBooking();
            }

            Assert.AreEqual(2, fakeDB.Data.Count);
            Assert.AreEqual(100m, fakeDB.Data[0].Amount);
            Assert.AreEqual("title", fakeDB.Data[0].TransactionTitle);
            Assert.AreEqual("123", fakeDB.Data[0].SourceAccountNo);
            Assert.AreEqual("456", fakeDB.Data[0].DestAccountNo);
            Assert.AreEqual("ref1", fakeDB.Data[0].UniqueRef);
        }
    }
}
