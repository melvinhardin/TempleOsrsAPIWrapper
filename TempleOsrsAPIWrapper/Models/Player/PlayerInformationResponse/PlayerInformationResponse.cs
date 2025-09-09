using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerInformationResponse
{
    public class PlayerInformationResponse
    {
        public string? Username { get; set; }
        [JsonPropertyName("player_name_with_capitalization")]
        public string? PlayerNameWithCapitalization { get; set; }
        public string? Country { get; set; }
        [JsonPropertyName("Game mode")]
        public byte Gamemode { get; set; }
        public byte GIM { get; set; }
        [JsonPropertyName("fresh_start_account")]
        public byte FreshStartAccount { get; set; }
        [JsonPropertyName("Cb-3")]
        public byte Cb3 { get; set; }
        public byte F2p { get; set; }
        public byte Banned { get; set; }
        public byte Disqualified { get; set; }
        [JsonPropertyName("Clan preference")]
        public int? ClanPreference { get; set; }
        [JsonPropertyName("Last checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("Last changed")]
        public string? LastChanged { get; set; }
        [JsonPropertyName("Last changed KC")]
        public string? LastChangedKC { get; set; }
        [JsonPropertyName("collection_log")]
        public CollectionLogResponse? CollectionLog { get; set; }
        [JsonPropertyName("Datapoint Cooldown")]
        public string? DatapointCooldown { get; set; }
    }
}
