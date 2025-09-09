using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerNamesResponse
{
    public class HistoryResponse
    {
        public string? Name { get; set; }
        [JsonPropertyName("last_date")]
        public string? LastDate { get; set; }
        [JsonPropertyName("first_date")]
        public string? FirstDate { get; set; }
        public int Seconds { get; set; }
        public float Ehp { get; set; }
        public int Xp { get; set; }
    }
}
