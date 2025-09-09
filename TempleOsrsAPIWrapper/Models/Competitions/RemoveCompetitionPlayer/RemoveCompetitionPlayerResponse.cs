using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.RemoveCompetitionPlayer
{
    /// <summary>
    /// Response model for removing players from a competition.
    /// </summary>
    public class RemoveCompetitionPlayerResponse
    {
        /// <summary>
        /// The ammount of players removed from the competition.
        /// </summary>
        [JsonPropertyName("removed_names_count")]
        public int RemovedNamesCount { get; set; }
        /// <summary>
        /// The old number of participants in the competition before removing players.
        /// </summary>
        [JsonPropertyName("old_participant_count")]
        public int OldParticipantCount { get; set; }
        /// <summary>
        /// The new number of participants in the competition after removing players.
        /// </summary>
        [JsonPropertyName("new_participant_count")]
        public int NewParticipantCount { get; set; }
        /// <summary>
        /// A list of names that were successfully removed from the competition.
        /// </summary>
        [JsonPropertyName("removed_names_list")]
        public string[]? RemovedNamesList { get; set; }
    }
}
