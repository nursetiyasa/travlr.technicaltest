using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travlr.TechnicalTest.Domain;

namespace Travlr.TechnicalTest.Applications.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductResult> Get(int id);
    }
}