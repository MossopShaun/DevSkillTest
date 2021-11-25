using BookingGatewayRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingGatewayService
{
    /// <summary>
    /// TODO: The class should be protected from inheritance!
    /// </summary>
    public class BookingGatewayFactory
    {

        /// <summary>
        /// TOOD: The method should create instance of IBookingGateway
        /// </summary>
        /// <param name="repository"></param>
        /// <returns></returns>
        public static IBookingGateway CreateGateway(IDBRepository repository)
        {
            IBookingGateway Gateway = new BookingGateway(repository);
           
            return Gateway;
        }

        /// <summary>
        /// TODO: The method should be deprecated, but developer can use it!
        /// </summary>
        /// <returns></returns>
        public static object CreateObject()
        {
            return new BookingGatewayFactory();
        }

        /// <summary>
        /// TODO: The method should be deprecated! Developer cannot use it! If use it there should be compilation error!
        /// </summary>
        /// <returns></returns>

        public static object NewObject()
        {
            return new Object();
        }
    }
}
