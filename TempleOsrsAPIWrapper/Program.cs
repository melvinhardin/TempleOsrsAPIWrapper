using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using TempleOsrsAPIWrapper.http;
using TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition;
using TempleOsrsAPIWrapper.Utils;

Console.WriteLine("Starting tests");

var services = new ServiceCollection();

services.AddHttpClient<HttpRequestHandler>(TempleClient =>
{
    TempleClient.BaseAddress = new Uri("https://templeosrs.com/api/");
});
services.AddScoped<TempleOsrsUserApiClientService>();
services.AddScoped<TempleOsrsCompetitionApiClientService>();
services.AddScoped<TempleOsrsGroupApiClientService>();
services.AddScoped<TempleOsrsCollectionApiClientService>();
var provider = services.BuildServiceProvider();
var apiCollectionClient = provider.GetRequiredService<TempleOsrsCollectionApiClientService>();
var apiUserClient = provider.GetRequiredService<TempleOsrsUserApiClientService>();
var apiCompetitionClient = provider.GetRequiredService<TempleOsrsCompetitionApiClientService>();
var apiGroupClient = provider.GetRequiredService<TempleOsrsGroupApiClientService>();


Console.WriteLine("Ending Tests");

