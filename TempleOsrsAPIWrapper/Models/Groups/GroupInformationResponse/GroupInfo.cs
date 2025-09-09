using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupInformationResponse
{
    public class GroupInfo
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        [JsonPropertyName("youtube_link")]
        public string? YoutubeLink { get; set; }
        [JsonPropertyName("twitter_link")]
        public string? TwitterLink { get; set; }
        [JsonPropertyName("twitch_link")]
        public string? TwitchLink { get; set; }
        [JsonPropertyName("discord_link")]
        public string? DiscordLink { get; set; }
        [JsonPropertyName("forum_link")]
        public string? ForumLink { get; set; }
        [JsonPropertyName("total_xp")]
        public long? TotalXp { get; set; }
        [JsonPropertyName("average_xp")]
        public long? AverageXp { get; set; }
        [JsonPropertyName("total_ehp")]
        public float? TotalEhp { get; set; }
        [JsonPropertyName("average_ehp")]
        public float? AverageEhp { get; set; }
        [JsonPropertyName("total_ehb")]
        public float? TotalEhb { get; set; }
        [JsonPropertyName("average_ehb")]
        public float? AverageEhb { get; set; }
        [JsonPropertyName("clan_type")]
        public string? ClanType { get; set; }
        [JsonPropertyName("clan_type_id")]
        public int? ClanTypeId { get; set; }
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }
    }
}
