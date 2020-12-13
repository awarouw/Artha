using Artha.Client.Helpers;
using Artha.Client.Services;
using Artha.Client.Services.Interface;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Artha.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IHttpService, HttpService>();

            builder.Services.AddScoped<IDriverService, DriverService>();
            builder.Services.AddScoped<ICountryService, CountryService>();
            builder.Services.AddScoped<ILocationService, LocationService>();
            builder.Services.AddScoped<IFixedAssetService, FixedAssetService>();
            builder.Services.AddScoped<IRouteService, RouteService>();

            await builder.Build().RunAsync();
        }
    }
}
