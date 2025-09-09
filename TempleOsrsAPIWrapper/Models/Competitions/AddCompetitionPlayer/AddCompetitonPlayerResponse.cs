using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.AddCompetitionPlayer
{
    /// <summary>
    /// Response model for adding players to a competition.
    /// </summary>
    public class AddCompetitonPlayerResponse
    {
        /// <summary>
        /// Number of names that were successfully added to the competition.
        /// </summary>
        [JsonPropertyName("added_names_count")]
        public short AddedNamesCount { get; set; }
        /// <summary>
        /// Old number of participants in the competition before adding new players.
        /// </summary>
        [JsonPropertyName("old_participant_count")]
        public short OldParticipantCount { get; set; }
        /// <summary>
        /// New number of participants in the competition after adding new players.
        /// </summary>
        [JsonPropertyName("new_participant_count")]
        public short NewParticipantCount { get; set; }
        /// <summary>
        /// List of names that were successfully added to the competition.
        /// </summary>
        [JsonPropertyName("added_names_list")]
        public string[]? AddedNamesList { get; set; }
    }
}
