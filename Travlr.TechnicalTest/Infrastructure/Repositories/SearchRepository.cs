using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Travlr.TechnicalTest.Applications.Interfaces;
using Travlr.TechnicalTest.Domain;
using Travlr.TechnicalTest.Core;

namespace Travlr.TechnicalTest.Infrastructure.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<List<SearchResult>> Search(string keyword, string lat, string lng)
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add(ClientApiAuth.ApiKeyName, ClientApiAuth.ApiKeyValue);

            var enPoint =
                $"{ClientApiAuth.ApiEndPoint}/search?q={keyword}&lat={lat.ToString(CultureInfo.InvariantCulture).Replace(",", ".")}&lng={lng.ToString(CultureInfo.InvariantCulture).Replace(",", ".")}";
            var taskResult = Client.GetStreamAsync(enPoint);

            var repositories = await JsonSerializer.DeserializeAsync<List<SearchResult>>(await taskResult);

            return repositories;
        }
    }
}