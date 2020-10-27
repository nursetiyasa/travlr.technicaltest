using System.Collections.Generic;
using System.Threading.Tasks;
using Travlr.TechnicalTest.Domain;

namespace Travlr.TechnicalTest.Applications.Interfaces
{
    public interface ISearchRepository
    {
        Task<List<SearchResult>> Search(string keyword, string lat, string lng);
    }
}