using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    public class CreateCompetitionResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("team-competition")]
        public byte? TeamCompetition { get; set; }
        [JsonPropertyName("skill")]
        public byte? Skill { get; set; }
        [JsonPropertyName("skill-name")]
        public string? SkillName { get; set; }
        [JsonPropertyName("start-date")]
        public string? StartDate { get; set; }
        [JsonPropertyName("start-date-unix")]
        public int? StartDateUnix { get; set; }
        [JsonPropertyName("end-date")]
        public string? EndDate { get; set; }
        [JsonPropertyName("end-date-unix")]
        public int? EndDateUnix { get; set; }
        [JsonPropertyName("participant-count")]
        public short? ParticipantCount { get; set; }
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        [JsonPropertyName("linked-group-id")]
        public int? LinkedToGroup { get; set; }
        [JsonPropertyName("synced-to-group")]
        public byte? SyncedGroupId { get; set; }
        [JsonPropertyName("league_v_competition")]
        public byte LeagueVCompetition { get; set; }
        [JsonPropertyName("participants")]
        public string[]? Participants { get; set; }
        [JsonPropertyName("teams")]
        public Dictionary<string, string[]>? Teams { get; set; }

    }
}
