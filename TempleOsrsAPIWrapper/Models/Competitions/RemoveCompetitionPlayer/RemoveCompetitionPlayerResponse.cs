using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.RemoveCompetitionList
{
    public class RemoveCompetitionPlayerResponse
    {
        [JsonPropertyName("removed_names_count")]
        public int RemovedNamesCount { get; set; }
        [JsonPropertyName("old_participant_count")]
        public int OldParticipantCount { get; set; }
        [JsonPropertyName("new_participant_count")]
        public int NewParticipantCount { get; set; }
        [JsonPropertyName("removed_names_list")]
        public string[]? RemovedNamesList { get; set; }
    }
}
