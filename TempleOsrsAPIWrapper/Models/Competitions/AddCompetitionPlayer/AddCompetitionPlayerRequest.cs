using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.AddCompetitionPlayer
{
    /// <summary>
    /// Model for adding players to a competition. Either the <see cref="Players"/> or <see cref="Teams"/> field is required.
    /// </summary>
    public class AddCompetitionPlayerRequest
    {
        /// <summary>
        /// Id of the competition to add players to.
        /// </summary>
        [JsonPropertyName("id")]
        required public int Id { get; set; }
        /// <summary>
        /// Key of the competition to add players to.
        /// </summary>
        [JsonPropertyName("key")]
        required public string Key { get; set; }
        /// <summary>
        /// The list of players as a JSON-encoded string.
        /// </summary>
        [JsonPropertyName("players")]
        public string? Players { get; set; }
        /// <summary>
        /// Dictionary of teams with the team name as the key and a list of players as the value.
        /// </summary>
        public Dictionary<string, string?>? Teams { get; set; }
    }
}
