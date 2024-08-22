using Eventor.Core;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorBuilds.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            /*
                * Code for our notification/event service 
            */
            builder.Services.AddScoped<EventAggregator>();

            await builder.Build().RunAsync();
        }
    }
}
