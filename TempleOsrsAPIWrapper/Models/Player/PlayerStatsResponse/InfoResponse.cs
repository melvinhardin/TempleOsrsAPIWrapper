using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerStatsResponse
{
    public class InfoResponse
    {
        public string? UserName { get; set; }
        public string? Country { get; set; }
        [JsonPropertyName("Game mode")]
        public byte GameMode { get; set; }
        [JsonPropertyName("Cb-3")]
        public byte Cb3 { get; set; }
        public byte F2p { get; set; }
        public byte Banned { get; set; }
        public byte Disqualified { get; set; }
        [JsonPropertyName("Clan preference")]
        public int? ClanPreference { get; set; }
        [JsonPropertyName("Last checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("Last checked unix")]
        public int LastCheckedUnix { get; set; }
        [JsonPropertyName("Primary_ehp")]
        public string? PrimaryEhp { get; set; }
        [JsonPropertyName("Primary_ehb")]
        public string? PrimaryEhb { get; set; }
        [JsonPropertyName("player_name_with_capitalization")]
        public string? PlayerNameWithCapitalization { get; set; }
    }
}
