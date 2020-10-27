using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Travlr.TechnicalTest.Applications.Interfaces;
using Travlr.TechnicalTest.Core;
using Travlr.TechnicalTest.Domain;

namespace Travlr.TechnicalTest.Infrastructure.Repositories
{
    public class PaxRepository : IPaxRepository
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<Pax> Post(string firstName, string lastName, string email)
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add(ClientApiAuth.ApiKeyName, ClientApiAuth.ApiKeyValue);

            var enPoint =
                $"{ClientApiAuth.ApiEndPoint}/pax";

            var postPax = new Pax { First = firstName, Last = lastName, Email = email};
            var postPaxJson = JsonConvert.SerializeObject(postPax);
            var repositories = await Client.PostAsync(enPoint, new StringContent(postPaxJson, Encoding.UTF8, "application/json"));

            repositories.EnsureSuccessStatusCode();
            var responseBody = await repositories.Content.ReadAsStringAsync();
            var deserializeResponse = JsonConvert.DeserializeObject<Pax>(responseBody);
            return deserializeResponse;
        }
    }
}
