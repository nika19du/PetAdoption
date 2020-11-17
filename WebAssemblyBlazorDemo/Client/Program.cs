using System;
using System.Threading.Tasks;
using WebAssemblyBlazorDemo.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace WebAssemblyBlazorDemo.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
             
            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("AnimalShelter.ServerAPI"));
            builder.Services.AddSingleton<IAnimalService, AnimalService>();
            builder.Services.AddSingleton<IProductService, ProductService>();

            await builder.Build().RunAsync();
        }
    }
}
