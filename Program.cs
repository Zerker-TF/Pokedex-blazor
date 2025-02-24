using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PokDex;
using PokDex.Util;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Añado el servicio de PokeClient para poder hacer las query a la PokeAPI
builder.Services.AddScoped<PokeClient>();
builder.Services.AddScoped<DexRegion>();
await builder.Build().RunAsync();
