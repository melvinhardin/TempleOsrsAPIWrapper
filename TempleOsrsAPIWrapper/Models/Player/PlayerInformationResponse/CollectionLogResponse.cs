using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerInformationResponse
{
    public class CollectionLogResponse
    {
        [JsonPropertyName("log synced")]
        public byte LogSynced { get; set; }
        [JsonPropertyName("last checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("last changed")]
        public string? LastChanged { get; set; }

    }
}
