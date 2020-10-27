using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Travlr.TechnicalTest.Applications.Interfaces;
using Travlr.TechnicalTest.Core;
using Travlr.TechnicalTest.Domain;

namespace Travlr.TechnicalTest.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<ProductResult> Get(int id)
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add(ClientApiAuth.ApiKeyName, ClientApiAuth.ApiKeyValue);

            try
            {
                var enPoint =
                    $"{ClientApiAuth.ApiEndPoint}/products/{id}";
                var taskResult = Client.GetStreamAsync(enPoint);
                var repositories = await JsonSerializer.DeserializeAsync<ProductResult>(await taskResult);
                return repositories;
            }
            catch
            {
                return null;
            }
        }
    }
}
