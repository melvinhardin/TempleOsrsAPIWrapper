using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerDatapointsResponse
{
    public class DatapointSkillResponse
    {
        public long Overall { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Strength { get; set; }
        public int Hitpoints { get; set; }
        public int Ranged { get; set; }
        public int Prayer { get; set; }
        public int Magic { get; set; }
        public int Cooking { get; set; }
        public int Woodcutting { get; set; }
        public int Fletching { get; set; }
        public int Fishing { get; set; }
        public int Firemaking { get; set; }
        public int Crafting { get; set; }
        public int Smithing { get; set; }
        public int Mining { get; set; }
        public int Herblore { get; set; }
        public int Agility { get; set; }
        public int Thieving { get; set; }
        public int Slayer { get; set; }
        public int Farming { get; set; }
        public int Runecraft { get; set; }
        public int Hunter { get; set; }
        public int Construction { get; set; }
        public float Ehp { get; set; }
        [JsonPropertyName("im_ehp")]
        public float ImEhp { get; set; }
        [JsonPropertyName("uim_ehp")]
        public float UimEhp { get; set; }
        [JsonPropertyName("lvl3_ehp")]
        public float Lvl3Ehp { get; set; }
        [JsonPropertyName("f2p_ehp")]
        public float F2pEhp { get; set; }
        [JsonPropertyName("1def_ehp")]
        public float OneDefEhp { get; set; }
    }
}
