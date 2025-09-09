using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    public class CreateCompetitionStandardRequest
    {
        [JsonPropertyName("name")]
        required public string Name { get; set; }
        [JsonPropertyName("skill")]
        required public string Skill { get; set; }
        [JsonPropertyName("team-comp")]
        public bool TeamComp { get; } = false;
        [JsonPropertyName("participants")]
        required public string[] Participants { get; set; }
        [JsonPropertyName("start-date")]
        required public long StartDate { get; set; }
        [JsonPropertyName("end-date")]
        required public long EndDate { get; set; }
        [JsonPropertyName("group-id")]
        public int? GroupId { get; set; } = null;
        [JsonPropertyName("group-key")]
        public string? GroupKey { get; set; } = null;
        [JsonPropertyName("group-sync")]
        public byte? GroupSync {  get; set; } = null;

    }
}
