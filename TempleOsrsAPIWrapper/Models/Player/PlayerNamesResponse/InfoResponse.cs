using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerNamesResponse
{
    public class InfoResponse
    {
        [JsonPropertyName("total_history_seconds")]
        public int TotalHistorySeconds { get; set; }
    }
}
