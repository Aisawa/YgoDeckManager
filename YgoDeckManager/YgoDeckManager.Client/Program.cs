using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using YgoDeckManager.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddHttpClient<CardClientService>();

await builder.Build().RunAsync();
