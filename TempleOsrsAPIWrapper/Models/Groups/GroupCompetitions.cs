using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups
{
    public class GroupCompetitions
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        [JsonPropertyName("skill_index")]
        public int? SkillIndex { get; set; }
        public string? Skill { get; set; }
        [JsonPropertyName("start_date")]
        public string? StartDate { get; set; }
        [JsonPropertyName("start_date_unix_time")]
        public long? StartDateUnixTime { get; set; }
        [JsonPropertyName("end_date")]
        public string? EndDate { get; set; }
        [JsonPropertyName("end_date_unix_time")]
        public long? EndDateUnixTime { get; set; }
        public byte? Status { get; set; }
        [JsonPropertyName("status_test")]
        public string? StatusTest { get; set; }
        [JsonPropertyName("group_member_sync")]
        public int? GroupMemberSync { get; set; }
        [JsonPropertyName("participant_count")]
        public int? ParticipantCount { get; set; }
        [JsonPropertyName("team_competition")]
        public byte? TeamCompetition { get; set; }
    }
}
