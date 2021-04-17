using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlazorLoggerWrappers.Shared;

namespace BlazorLoggerWrappers.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient<IMessageLogger, ConsoleMessageLogger>();

            await builder.Build().RunAsync();
        }
    }
}
