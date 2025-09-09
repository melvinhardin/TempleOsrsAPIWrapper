using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.DeleteCompetition
{
    public class DeleteCompetitionResponse
    {
        [JsonPropertyName("competition_id")]
        public int CompetitionId { get; set; }
        public string? Message { get; set; }
    }
}
