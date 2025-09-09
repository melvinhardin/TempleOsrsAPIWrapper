using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.DeleteCompetition
{
    /// <summary>
    /// The response model for deleting a competition.
    /// </summary>
    public class DeleteCompetitionResponse
    {
        /// <summary>
        /// The id of the deleted competition.
        /// </summary>
        [JsonPropertyName("competition_id")]
        public int CompetitionId { get; set; }
        /// <summary>
        /// A message indicating the result of the delete operation.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
