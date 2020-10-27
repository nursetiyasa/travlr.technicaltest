using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travlr.TechnicalTest.Domain;

namespace Travlr.TechnicalTest.Applications.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> Post(int productId, List<string> paxId, string dateTime, int nights);
    }
}
