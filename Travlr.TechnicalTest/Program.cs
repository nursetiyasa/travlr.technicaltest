using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Travlr.TechnicalTest
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("apiKey", "5907faba-c11b-4f12-b8bb-28fbcd5c3803");

            var stringTask = client.GetStringAsync("https://staging.hero.travel/api/v2/properties");

            var msg = await stringTask;
            Console.Write(msg);
        }
        public static async Task Main(string[] args)
        {
            await ProcessRepositories();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
