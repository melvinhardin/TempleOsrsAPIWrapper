using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse
{
    /// <summary>
    /// A model representing the stats of a group member.
    /// </summary>
    public class GroupMemberStats
    {
        /// <summary>
        /// The player's RSN.
        /// </summary>
        public string? Player { get; set; }
        /// <summary>
        /// The player's RSN with ingame capitalization.
        /// </summary>
        [JsonPropertyName("player_name_with_capitalization")]
        public string? PlayerNameWithCapitalization { get; set; }
        /// <summary>
        /// If set the players country.
        /// </summary>
        public string? Country { get; set; }
        /// <summary>
        /// The game mode of the player. 0 = Normal, 1 = Ironman, 2 = Hardcore Ironman, 3 = Ultimate Ironman.
        /// </summary>
        [JsonPropertyName("game_mode")]
        public byte? GameMode { get; set; }
        /// <summary>
        /// A boolean (0 or 1) indicating if the player is a level 3 account.
        /// </summary>
        [JsonPropertyName("level_3")]
        public byte? Level3 { get; set; }
        /// <summary>
        /// A boolean (0 or 1) indicating if the player is a free to play account.
        /// </summary>
        [JsonPropertyName("free_to_play")]
        public byte? FreeToPlay { get; set; }
        /// <summary>
        /// Indicating what Group Ironman mode the player is in. 0 = Not GIM, 12 = Regular 2-player, 13 = Regular 3-player, 14 = Regular 4-player, 15 = Regular 5-player, 22 = HC 2-player, 23 = HC 3-player, 24 = HC 4-player, 25 = HC 5-player
        /// </summary>
        [JsonPropertyName("gim_mode")]
        public byte? GimMode { get; set; }
        /// <summary>
        /// League 4 points.
        /// </summary>
        [JsonPropertyName("leagues_iv_points")]
        public int? LeaguesIvPoints { get; set; }
        /// <summary>
        /// League 5 points.
        /// </summary>
        [JsonPropertyName("leagues_v_points")]
        public int? LeaguesVPoints { get; set; }
        /// <summary>
        /// If player is on hiscores, 1 = yes, 0 = no.
        /// </summary>
        [JsonPropertyName("on_hiscores")]
        public byte? OnHiscores { get; set; }
        /// <summary>
        /// Date and time the player's stats were last checked (ISO 8601 format, UTC).
        /// </summary>
        [JsonPropertyName("last_checked")]
        public string? LastChecked { get; set; }
        /// <summary>
        /// Unix timestamp representing when the player's stats were last checked (UTC).
        /// </summary>
        [JsonPropertyName("last_checked_unix_time")]
        public int? LastCheckedUnixTime { get; set; }
        /// <summary>
        /// Date and time the player's XP was last changed (ISO 8601 format, UTC).
        /// </summary>
        [JsonPropertyName("last_changed_xp")]
        public string? LastChangedXp { get; set; }
        /// <summary>
        /// Unix timestamp representing when the player's XP was last changed (UTC).
        /// </summary>
        [JsonPropertyName("last_changed_xp_unix_time")]
        public int? LastChangedXpUnixTime { get; set; }
        /// <summary>
        /// Date and time the player's kill count was last changed (ISO 8601 format, UTC).
        /// </summary>
        [JsonPropertyName("last_changed_kc")]
        public string? LastChangedKc { get; set; }
        /// <summary>
        /// Unix timestamp representing when the player's kill count was last changed (UTC).
        /// </summary>
        [JsonPropertyName("last_changed_kc_unix_time")]
        public int? LastChangedKcUnixTime { get; set; }

        [JsonPropertyName("join_date")]
        public string? JoinDate { get; set; }
        [JsonPropertyName("join_date_unix_time")]
        public int? JoinDateUnixTime { get; set; }
        /// <summary>
        /// If set, the player's skill stats.
        /// </summary>
        public GroupMemberSkills? Skills { get; set; }
        /// <summary>
        /// If set, the player's boss stats.
        /// </summary>
        public GroupMemberBosses? Bosses { get; set; }
    }
}
