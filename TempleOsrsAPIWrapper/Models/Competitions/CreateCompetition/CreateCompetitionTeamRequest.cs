using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    public class CreateCompetitionTeamRequest
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
        /// A boolean indicating if the competition is a team competition. Must be true for this request type.
        /// </summary>
        [JsonPropertyName("team-comp")]
        public bool TeamComp { get; } = true;
        /// <summary>
        /// A dictionary where the key is the team name and the value is a comma-separated list of RSN's to be added to that team.
        /// </summary>
        [JsonPropertyName("teams")]
        required public Dictionary<string, string> Teams { get; set; }
        /// <summary>
        /// The start date as a unix timestamp (UTC)
        /// </summary>
        [JsonPropertyName("start-date")]
        required public long StartDate { get; set; }
        /// <summary>
        /// The end date as a unix timestamp (UTC)
        /// </summary>
        [JsonPropertyName("end-date")]
        required public long EndDate { get; set; }
    }
}
