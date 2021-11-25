using BookingGatewayService.Tests;

namespace RunTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run Tests
            //GateWayFactory
            var GatewayFactoryTester = new BookingGatewayFactoryTest();
            GatewayFactoryTester.CheckIsBookingGatewayImplemented();
            GatewayFactoryTester.CheckIsDBRepositorySetInBookingGateway();

            //Service Tests
            var BookingGatewayTester = new BookingGatewayTest();
            BookingGatewayTester.StartBookingImplementationTest();
            BookingGatewayTester.EndBookingImplementationTest();
            BookingGatewayTester.EndBookingBeforeStartBookingImplementationTest();
            BookingGatewayTester.CheckBookingTest();
            BookingGatewayTester.CheckGetBookingStatusesTest();
            BookingGatewayTester.CheckBookingDataTest();

        }
    }
}