using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    /// <summary>
    /// The request model for creating a standard (non-team) competition.
    /// </summary>
    public class CreateCompetitionStandardRequest
    {
        /// <summary>
        /// The name of the competition.
        /// </summary>
        [JsonPropertyName("name")]
        required public string Name { get; set; }
        /// <summary>
        /// The skill or boss the competition is based on. Either lowercase skill/boss name, or number . Details can be found on <a href="https://templeosrs.com/js/skill_data.js"> https://templeosrs.com/js/skill_data.js</a>
        /// </summary>
        [JsonPropertyName("skill")]
        required public string Skill { get; set; }
        /// <summary>
        /// A boolean indicating if the competition is a team competition. Must be false for this request type.
        /// </summary>
        [JsonPropertyName("team-comp")]
        public bool TeamComp { get; } = false;
        /// <summary>
        /// A list of RSN's to be added to the competition.
        /// </summary>
        [JsonPropertyName("participants")]
        required public string[] Participants { get; set; }
        /// <summary>
        /// Start date as a unix timestamp (UTC)
        /// </summary>
        [JsonPropertyName("start-date")]
        required public long StartDate { get; set; }
        /// <summary>
        /// End date as a unix timestamp (UTC)
        /// </summary>
        [JsonPropertyName("end-date")]
        required public long EndDate { get; set; }
        /// <summary>
        /// If provided, the competition will be part of the specified group. Must be accompanied by a valid group key and group sync value.
        /// </summary>
        [JsonPropertyName("group-id")]
        public int? GroupId { get; set; } = null;
        /// <summary>
        /// If group-id is provided, this must be the valid group key for the specified group.
        /// </summary>
        [JsonPropertyName("group-key")]
        public string? GroupKey { get; set; } = null;
        /// <summary>
        /// A boolean (0 or 1) indicating if the participant list should be synced to the group if group-id is provided. 1 to sync, 0 to not sync.
        /// </summary>
        [JsonPropertyName("group-sync")]
        public byte? GroupSync {  get; set; } = null;

    }
}
