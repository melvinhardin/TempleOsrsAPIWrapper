using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.DeleteCompetition
{
    public class DeleteCompetitionRequest
    {
        [JsonPropertyName("id")]
        required public int Id { get; set; }
        [JsonPropertyName("key")]
        required public string Key { get; set; }
    }
}
