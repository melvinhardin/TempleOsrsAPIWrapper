using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    /// <summary>
    /// Response model after creating a competition.
    /// </summary>
    public class CreateCompetitionResponse
    {
        /// <summary>
        /// The unique id of the competition.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// The name of the competition.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// A boolean (0 or 1) indicating if the competition is a team competition.
        /// </summary>
        [JsonPropertyName("team-competition")]
        public byte? TeamCompetition { get; set; }
        /// <summary>
        /// An integer representing the skill or boss the competition is based on. See <a href="https://templeosrs.com/js/skill_data.js">https://templeosrs.com/js/skill_data.js</a> for details.
        /// </summary>
        [JsonPropertyName("skill")]
        public int? Skill { get; set; }
        /// <summary>
        /// the name of the skill or boss the competition is based on.
        /// </summary>
        [JsonPropertyName("skill-name")]
        public string? SkillName { get; set; }
        /// <summary>
        /// The ISO 8601 formatted start date and time for the competition (UTC)
        /// </summary>
        [JsonPropertyName("start-date")]
        public string? StartDate { get; set; }
        /// <summary>
        /// The unix timestamp representing the start date and time for the competition (UTC)
        /// </summary>
        [JsonPropertyName("start-date-unix")]
        public int? StartDateUnix { get; set; }
        /// <summary>
        /// ISO 8601 formatted end date and time for the competition (UTC)
        /// </summary>
        [JsonPropertyName("end-date")]
        public string? EndDate { get; set; }
        /// <summary>
        /// The unix timestamp representing the end date and time for the competition (UTC)
        /// </summary>
        [JsonPropertyName("end-date-unix")]
        public int? EndDateUnix { get; set; }
        [JsonPropertyName("participant-count")]
        /// The number of participants in the competition.
        public short? ParticipantCount { get; set; }
        /// <summary>
        /// The private key used to manage the competition.
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        /// <summary>
        /// If the competition is linked to a group, this field contains the group id. Null if not linked.
        /// </summary>
        [JsonPropertyName("linked-group-id")]
        public int? LinkedToGroup { get; set; }
        /// <summary>
        /// Boolean (0 or 1) indicating if the competition is synced to a group if it is linked. Null if not linked.
        /// </summary>
        [JsonPropertyName("synced-to-group")]
        public byte? SyncedGroupId { get; set; }
        /// <summary>
        /// Deprecated field, always 0.
        /// </summary>
        [JsonPropertyName("league_v_competition")]
        public byte LeagueVCompetition { get; set; }
        /// <summary>
        /// A list of participants in the competition.
        /// </summary>
        [JsonPropertyName("participants")]
        public string[]? Participants { get; set; }
        /// <summary>
        /// If a team competition, this field contains a dictionary with the team name as the key and a list of participants as the value.
        /// </summary>
        [JsonPropertyName("teams")]
        public Dictionary<string, string[]>? Teams { get; set; }

    }
}
