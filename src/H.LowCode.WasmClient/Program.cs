using H.LowCode.RenderEngine;
using H.LowCode.RenderEngine.Html;
using H.LowCode.Theme;
using H.LowCode.Theme.AntBlazorPro.Shared;
using H.LowCode.Theme.Html.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.WasmClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IRender, HtmlRender>();
            builder.Services.AddScoped<MainLayout, HtmlMainLayout>();

            //builder.Services.AddScoped<IRender, AntBlazorRender>();
            //builder.Services.AddScoped<MainLayout, AntProMainLayout>();

            await builder.Build().RunAsync();
        }
    }
}
