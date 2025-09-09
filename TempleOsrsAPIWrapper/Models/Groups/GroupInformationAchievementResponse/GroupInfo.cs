using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupInformationAchievementResponse
{
    /// <summary>
    /// Generic group information.
    /// </summary>
    public class GroupInfo
    {
        /// <summary>
        /// The ID of the group.
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The name of the group.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// If it exists the group's youtube link.
        /// </summary>
        [JsonPropertyName("youtube_link")]
        public string? YoutubeLink { get; set; }
        /// <summary>
        /// If it exists the group's twitter link.
        /// </summary>
        [JsonPropertyName("twitter_link")]
        public string? TwitterLink { get; set; }
        /// <summary>
        /// If it exists the group's twitch link.
        /// </summary>
        [JsonPropertyName("twitch_link")]
        public string? TwitchLink { get; set; }
        /// <summary>
        /// If it exists the group's discord link.
        /// </summary>
        [JsonPropertyName("discord_link")]
        public string? DiscordLink { get; set; }
        /// <summary>
        /// If it exists the group's forum link.
        /// </summary>
        [JsonPropertyName("forum_link")]
        public string? ForumLink { get; set; }
        /// <summary>
        /// The total XP of all group members.
        /// </summary>
        [JsonPropertyName("total_xp")]
        public long? TotalXp { get; set; }
        /// <summary>
        /// The average XP of all group members.
        /// </summary>
        [JsonPropertyName("average_xp")]
        public long? AverageXp { get; set; }
        /// <summary>
        /// The total EHP of all group members.
        /// </summary>
        [JsonPropertyName("total_ehp")]
        public float? TotalEhp { get; set; }
        /// <summary>
        /// The average EHP of all group members.
        /// </summary>
        [JsonPropertyName("average_ehp")]
        public float? AverageEhp { get; set; }
        /// <summary>
        /// The total EHB of all group members.
        /// </summary>
        [JsonPropertyName("total_ehb")]
        public float? TotalEhb { get; set; }
        /// <summary>
        /// The average EHB of all group members.
        /// </summary>
        [JsonPropertyName("average_ehb")]
        public float? AverageEhb { get; set; }
        /// <summary>
        /// The type of clan if set.
        /// </summary>
        [JsonPropertyName("clan_type")]
        public string? ClanType { get; set; }
        /// <summary>
        /// Number format of the clan type if set.
        /// </summary>
        [JsonPropertyName("clan_type_id")]
        public int? ClanTypeId { get; set; }
        /// <summary>
        /// The ammount of members in the group.
        /// </summary>
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }
    }
}
