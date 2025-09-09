using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    public class InfoResponse
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public byte Status { set; get; }
        [JsonPropertyName("participant_count")]
        public ushort ParticipantCount { set; get; }
        [JsonPropertyName("team_competition")]
        public byte TeamCompetition { get; set; }
        [JsonPropertyName("skill_competition")]
        public byte SkillCompetition { get; set; }
        public string? skill { get; set; }
        [JsonPropertyName("skill_index")]
        public byte SkillIndex { get; set; }
        [JsonPropertyName("start_date")]
        public string? StartDate { get; set; }
        [JsonPropertyName("end_date")]
        public string? EndDate { get; set; }
        [JsonPropertyName("start_date_unix")]
        public int StartDateUnix { get; set; }
        [JsonPropertyName("end_date_unix")]
        public int EndDateUnix { get; set; }
        [JsonPropertyName("now_time")]
        public string? NowTime { get; set; }
        [JsonPropertyName("now_time_unix")]
        public int NowTimeUnix { get; set; }
        [JsonPropertyName("linked_group_id")]
        public int? LinkedGroupId { get; set; }
        [JsonPropertyName("linked_group_name")]
        public string? LinkedGroupName { get; set; }
        [JsonPropertyName("group_member_sync")]
        public int GroupMemberSync { get; set; }
        [JsonPropertyName("league_v_competition")]
        public int LeagueVCompetition { get; set; }
    }
}
