using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.RemoveCompetitionList
{
    public class RemoveCompetitionPlayerRequest
    {
        [JsonPropertyName("id")]
        required public int Id { get; set; }
        [JsonPropertyName("key")]
        required public string Key { get; set; }
        [JsonPropertyName("players")]
        required public string Players { get; set; }
    }
}
