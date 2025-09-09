using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.DeleteCompetition
{
    /// <summary>
    /// Request model for deleting a competition.
    /// </summary>
    public class DeleteCompetitionRequest
    {
        /// <summary>
        /// The id of the competition to delete.
        /// </summary>
        [JsonPropertyName("id")]
        required public int Id { get; set; }
        /// <summary>
        /// The private key of the competition to delete.
        /// </summary>
        [JsonPropertyName("key")]
        required public string Key { get; set; }
    }
}
