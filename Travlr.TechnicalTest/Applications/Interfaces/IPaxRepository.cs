using System.Threading.Tasks;
using Travlr.TechnicalTest.Domain;

namespace Travlr.TechnicalTest.Applications.Interfaces
{
    public interface IPaxRepository
    {
        Task<Pax> Post(string firstName, string lastName, string email);
    }
}
