using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.RemoveCompetitionPlayer
{
    /// <summary>
    /// A request model for removing players from a competition.
    /// </summary>
    public class RemoveCompetitionPlayerRequest
    {
        /// <summary>
        /// The competition id.
        /// </summary>
        [JsonPropertyName("id")]
        required public int Id { get; set; }
        /// <summary>
        /// The private key of the competition.
        /// </summary>
        [JsonPropertyName("key")]
        required public string Key { get; set; }
        /// <summary>
        /// A List of players to remove as a JSON-encoded string.
        /// </summary>
        [JsonPropertyName("players")]
        required public string Players { get; set; }
    }
}
