﻿using H.LowCode.Theme.Html.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.Theme.Html
{
    public static class WebAssemblyHostBuilderExtensions
    {
        public static void AddHtmlTheme(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


        }
    }
}