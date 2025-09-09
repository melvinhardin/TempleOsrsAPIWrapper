using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.AddCompetitionList
{
    public class AddCompetitionPlayerRequest
    {
        [JsonPropertyName("id")]
        required public int Id { get; set; }
        [JsonPropertyName("key")]
        required public string Key { get; set; }
        [JsonPropertyName("players")]
        public string? Players { get; set; }
        public Dictionary<string, string?>? Teams { get; set; }
    }
}
