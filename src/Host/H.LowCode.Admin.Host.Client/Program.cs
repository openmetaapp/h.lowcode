using H.LowCode;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

#region  LowCode
builder.Services.AddLowCode();
#endregion

await builder.Build().RunAsync();