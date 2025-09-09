using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.AddCompetitionList
{
    public class AddCompetitonPlayerResponse
    {
        [JsonPropertyName("added_names_count")]
        public short AddedNamesCount { get; set; }
        [JsonPropertyName("old_participant_count")]
        public short OldParticipantCount { get; set; }
        [JsonPropertyName("new_participant_count")]
        public short NewParticipantCount { get; set; }
        [JsonPropertyName("added_names_list")]
        public string[]? AddedNamesList { get; set; }
    }
}
