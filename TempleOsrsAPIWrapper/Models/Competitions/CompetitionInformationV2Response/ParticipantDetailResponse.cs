using System.Text.Json;
using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    public class ParticipantDetailResponse
    {
        public string? Username { get; set; }
        [JsonPropertyName("player_name_with_capitalization")]
        public string? PlayerNameWithCapitalization { get; set; }
        public int? Gain { get; set; }
        [JsonPropertyName("end_xp")]
        public int? EndXp { get; set; }
        [JsonPropertyName("start_xp")]
        public int? StartXp { get; set; }
        [JsonPropertyName("last_checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("last_changed")]
        public string? LastChanged { get; set; }
        [JsonPropertyName("last_checked_unix")]
        public long? LastCheckedUnix { get; set; }
        [JsonPropertyName("last_changed_unix")]
        public long? LastChangedUnix { get; set; }
        [JsonPropertyName("first_checked_during_comp_unix")]
        public long? FirstCheckedDuringCompUnix { get; set; }
        [JsonPropertyName("last_checked_during_comp_unix")]
        public long? LastCheckedDuringCompUnix { get; set; }
        public int? Team { get; set; }
        [JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        [JsonPropertyName("detailed_gains")]
        public JsonElement? DetailedGains { get; set; }

        [JsonPropertyName("has_datapoints")]
        public bool HasDatapoints { get; set; }
        [JsonPropertyName("on_hiscores")]
        public int OnHiscores { get; set; }
    }
}
