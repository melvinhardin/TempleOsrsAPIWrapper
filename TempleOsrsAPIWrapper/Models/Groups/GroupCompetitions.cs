using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups
{
    /// <summary>
    /// A model representing competitions within a group.
    /// </summary>
    public class GroupCompetitions
    {
        /// <summary>
        /// Id of the competition.
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Name of the competition.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// A number representing the skill or boss the competition is based on. See <a href="https://templeosrs.com/js/skill_data.js">https://templeosrs.com/js/skill_data.js</a> for details.
        /// </summary>
        [JsonPropertyName("skill_index")]
        public int? SkillIndex { get; set; }
        /// <summary>
        /// The verbose name of the skill or boss the competition is based on.
        /// </summary>
        public string? Skill { get; set; }
        /// <summary>
        /// The start date of the competition in ISO 8601 format (UTC).
        /// </summary>
        [JsonPropertyName("start_date")]
        public string? StartDate { get; set; }
        /// <summary>
        /// The start date of the competition as a unix timestamp (UTC).
        /// </summary>
        [JsonPropertyName("start_date_unix_time")]
        public long? StartDateUnixTime { get; set; }
        /// <summary>
        /// The end date of the competition in ISO 8601 format (UTC).
        /// </summary>
        [JsonPropertyName("end_date")]
        public string? EndDate { get; set; }
        /// <summary>
        /// The end date of the competition as a unix timestamp (UTC).
        /// </summary>
        [JsonPropertyName("end_date_unix_time")]
        public long? EndDateUnixTime { get; set; }
        /// <summary>
        /// The status enum of the competition.
        /// </summary>
        public byte? Status { get; set; }
        /// <summary>
        /// The verbose status of the competition.
        /// </summary>
        [JsonPropertyName("status_text")]
        public string? StatusText { get; set; }
        /// <summary>
        /// If the group members are synced to the competition, this field is 1. If not, it is 0.
        /// </summary>
        [JsonPropertyName("group_member_sync")]
        public int? GroupMemberSync { get; set; }
        /// <summary>
        /// The number of participants in the competition.
        /// </summary>
        [JsonPropertyName("participant_count")]
        public int? ParticipantCount { get; set; }
        /// <summary>
        /// A bool (0 or 1) indicating if the competition is a team competition.
        /// </summary>
        [JsonPropertyName("team_competition")]
        public byte? TeamCompetition { get; set; }
    }
}
