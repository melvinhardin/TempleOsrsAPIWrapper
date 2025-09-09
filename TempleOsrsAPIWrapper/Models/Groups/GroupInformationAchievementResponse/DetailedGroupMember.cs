using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupInformationAchievementResponse
{
    public class DetailedGroupMember
    {
        [JsonPropertyName("last_checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("last_checked_unix_time")]
        public long? LastCheckedUnixTime { get; set; }
        [JsonPropertyName("last_changed")]
        public string? LastChanged { get; set; }
        [JsonPropertyName("last_changed_unix_time")]
        public long? LastChangedUnixTime { get; set; }
        [JsonPropertyName("inferno_cape")]
        public bool? InfernoCape { get; set; }
        [JsonPropertyName("max_cape")]
        public bool? MaxCape { get; set; }
        [JsonPropertyName("xerics_cape_level")]
        public byte? XericsCapeLevel { get; set; }
        [JsonPropertyName("sinhaza_shroud_level")]
        public byte? SinhazaShroudLevel { get; set; }
        [JsonPropertyName("total_ehp")]
        public float? TotalEhp { get; set; }
        [JsonPropertyName("total_primary_ehp")]
        public float? TotalPrimaryEhp { get; set; }
        [JsonPropertyName("total_xp")]
        public long? TotalXp { get; set; }
    }
}
