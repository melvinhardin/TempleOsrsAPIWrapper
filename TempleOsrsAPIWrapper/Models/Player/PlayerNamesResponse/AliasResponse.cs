using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerNamesResponse
{
    public class AliasResponse
    {
        public string? Name { get; set; }
        [JsonPropertyName("last_used")]
        public string? LastUsed { get; set; }
        [JsonPropertyName("last_used_seconds")]
        public int LastUsedSeconds { get; set; }
        [JsonPropertyName("ehp_gained")]
        public float EhpGained { get; set; }
        [JsonPropertyName("time_used")]
        public int TimeUsed { get; set; }
    }
}
