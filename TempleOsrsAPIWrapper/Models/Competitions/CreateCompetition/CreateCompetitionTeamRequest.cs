using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    public class CreateCompetitionTeamRequest
    {
        [JsonPropertyName("name")]
        required public string Name { get; set; }
        [JsonPropertyName("skill")]
        required public string Skill { get; set; }
        [JsonPropertyName("team-comp")]
        public bool TeamComp { get; } = true;
        [JsonPropertyName("teams")]
        required public Dictionary<string, string> Teams { get; set; }
        [JsonPropertyName("start-date")]
        required public long StartDate { get; set; }
        [JsonPropertyName("end-date")]
        required public long EndDate { get; set; }
    }
}
