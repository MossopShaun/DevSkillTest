using BookingGatewayRepository;
using BookingGatewayRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingGatewayService
{
    public class BookingGateway : IBookingGateway
    {
        private readonly IDBRepository repository;
        private Thread booking = new Thread(BookingThread.DoWork);
        public BookingGateway(IDBRepository repo)
        {
            repository = repo;
        }

        public IDBRepository DBRepository { get => repository; set => throw new NotImplementedException(); }

        public void Booking(string uniqueReference, decimal amount, string transactonTitle, string srcAccountNo, string destAccountNo)
        {
            var requet = new TransactionData()
            {
                SourceAccountNo = srcAccountNo,
                Amount = amount,
                DestAccountNo = destAccountNo,
                TransactionTitle = transactonTitle,
                UniqueRef = uniqueReference

            };

            repository.SaveBooking(requet);
        }

        public void EndBooking()
        {
            booking.Abort();
        }

        public IList<TransactionStatus> GetBookingStatuses(IList<string> uniqueTransactionRefs)
        {
            return repository.GetStatuses(uniqueTransactionRefs.ToArray());
        }

        public void StartBooking()
        {
            booking.Start();
        }
    }
}
