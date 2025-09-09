using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse
{
    public class GroupMemberStats
    {
        public string? Player { get; set; }
        [JsonPropertyName("player_name_with_capitalization")]
        public string? PlayerNameWithCapitalization { get; set; }
        public string? Country { get; set; }
        [JsonPropertyName("game_mode")]
        public byte? GameMode { get; set; }
        [JsonPropertyName("level_3")]
        public byte? Level3 { get; set; }
        [JsonPropertyName("free_to_play")]
        public byte? FreeToPlay { get; set; }
        [JsonPropertyName("gim_mode")]
        public byte? GimMode { get; set; }
        [JsonPropertyName("leagues_iv_points")]
        public int? LeaguesIvPoints { get; set; }
        [JsonPropertyName("leagues_v_points")]
        public int? LeaguesVPoints { get; set; }
        [JsonPropertyName("on_hiscores")]
        public byte? OnHiscores { get; set; }
        [JsonPropertyName("last_checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("last_checked_unix_time")]
        public int? LastCheckedUnixTime { get; set; }
        [JsonPropertyName("last_changed_xp")]
        public string? LastChangedXp { get; set; }
        [JsonPropertyName("last_changed_xp_unix_time")]
        public int? LastChangedXpUnixTime { get; set; }
        [JsonPropertyName("last_changed_kc")]
        public string? LastChangedKc { get; set; }
        [JsonPropertyName("last_changed_kc_unix_time")]
        public int? LastChangedKcUnixTime { get; set; }
        [JsonPropertyName("join_date")]
        public string? JoinDate { get; set; }
        [JsonPropertyName("join_date_unix_time")]
        public int? JoinDateUnixTime { get; set; }
        public GroupMemberSkills? Skills { get; set; }
        public GroupMemberBosses? Bosses { get; set; }
    }
}
