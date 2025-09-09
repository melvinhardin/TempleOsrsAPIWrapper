using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupInformationAchievementResponse
{
    /// <summary>
    /// Detailed information about a group member's temple stats.
    /// </summary>
    public class DetailedGroupMember
    {
        /// <summary>
        /// When the user was last checked for updates.
        /// </summary>
        [JsonPropertyName("last_checked")]
        public string? LastChecked { get; set; }
        /// <summary>
        /// When the user was last checked for updates, in Unix time.
        /// </summary>
        [JsonPropertyName("last_checked_unix_time")]
        public long? LastCheckedUnixTime { get; set; }
        /// <summary>
        /// When the user last changed, in ISO 8601 format.
        /// </summary>
        [JsonPropertyName("last_changed")]
        public string? LastChanged { get; set; }
        /// <summary>
        /// When the user last changed, in Unix time.
        /// </summary>
        [JsonPropertyName("last_changed_unix_time")]
        public long? LastChangedUnixTime { get; set; }
        /// <summary>
        /// Boolean indicating if the user has an inferno cape.
        /// </summary>
        [JsonPropertyName("inferno_cape")]
        public bool? InfernoCape { get; set; }
        /// <summary>
        /// Boolean indicating if the user has a max cape.
        /// </summary>
        [JsonPropertyName("max_cape")]
        public bool? MaxCape { get; set; }
        /// <summary>
        /// A byte representing the level of the user's Xeric's Cape.
        /// </summary>
        [JsonPropertyName("xerics_cape_level")]
        public byte? XericsCapeLevel { get; set; }
        /// <summary>
        /// A byte representing the level of the user's Sinhaza's Shroud.
        /// </summary>
        [JsonPropertyName("sinhaza_shroud_level")]
        public byte? SinhazaShroudLevel { get; set; }
        /// <summary>
        /// The total EHP of the user.
        /// </summary>
        [JsonPropertyName("total_ehp")]
        public float? TotalEhp { get; set; }
        /// <summary>
        /// The total primary EHP of the user.
        /// </summary>
        [JsonPropertyName("total_primary_ehp")]
        public float? TotalPrimaryEhp { get; set; }
        /// <summary>
        /// The total xp of the user.
        /// </summary>
        [JsonPropertyName("total_xp")]
        public long? TotalXp { get; set; }
    }
}
