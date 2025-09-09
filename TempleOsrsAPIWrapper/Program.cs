using http.TempleOsrsApiClient;
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

//var test = await apiGroupClient.GetGroupMembers(948);

//var test = await apiCompetitionClient.AddPlayersCompetition(32274, ["Niv Alt", "Niv Lem"], "LE8vXzhwezV68b6IszUKHlX4S");
//Console.WriteLine(test);

//var test2 = await apiCompetitionClient.DeleteCompetition(32274, "LE8vXzhwezV68b6IszUKHlX4S");
//Console.WriteLine(test2);

//var test = await apiGroupClient.GetGroupCompetitions(948);
//Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));

//var test = await apiGroupClient.AddGroupMembers(3286, ["Niv Alt"],"YDUMCmMeA3Vo0zSqwkeJpQDkN");
//Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));


//var test = await apiCollectionClient.GetGroupCollections(3286);
//Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));

//var test2 = await apiCompetitionClient.AddCompetitionPlayers(32274, ["Niv_Lem", "Niv Alt"] ,"LE8vXzhwezV68b6IszUKHlX4S");

//Thread.Sleep(5000);
//var test = await apiCompetitionClient.DeleteCompetition(32401, "Zhf9etNHxCO9W8gFK3ElJgVnr");
//Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));

var newComp = new CreateCompetitionStandardRequest
{
    Name = "ObjectApiTest",
    StartDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 1800,
    EndDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 2700,
    Participants = ["Niv Lem"],
    Skill = "1",
    GroupId = 3286,
    GroupKey = "YDUMCmMeA3Vo0zSqwkeJpQDkN",
    GroupSync = 1
};



var test = await apiCompetitionClient.CreateCompetition(newComp);
Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));
//long timestart = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 1800; 
//long timeend = timestart + 900;

//var test2 = new TeamListInput
//{
//    Teams = new Dictionary<string, string[]>
//    { 
//        {"test", ["niv lem"] },
//        {"test2", ["niv alt"] } 
//    }
//};

//var test = apiCompetitionClient.CreateCompetition("apiTeamTest","0",timestart,timeend,test2);
//Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));


//Console.WriteLine($"{timestart} - {timeend}");
//var test = await apiCompetitionClient.CreateCompetition("nivapitest", "0", timestart, timeend, ["niv lem"]);

//var test2 = await apiCompetitionClient.GetCompetitionInfo(32274);
//Console.WriteLine(JsonSerializer.Serialize(test, new JsonSerializerOptions { WriteIndented = true }));
//Console.WriteLine(test);
Console.WriteLine("Ending Tests");

