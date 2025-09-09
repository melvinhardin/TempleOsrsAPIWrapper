using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    public class DetailedSkillGainsResponse
    {
        public DetailedStartEndResponse? Overall { get; set; }
        public DetailedStartEndResponse? Attack { get; set; }
        public DetailedStartEndResponse? Defence { get; set; }
        public DetailedStartEndResponse? Strength { get; set; }
        public DetailedStartEndResponse? Hitpoints { get; set; }
        public DetailedStartEndResponse? Ranged { get; set; }
        public DetailedStartEndResponse? Prayer { get; set; }
        public DetailedStartEndResponse? Magic { get; set; }
        public DetailedStartEndResponse? Cooking { get; set; }
        public DetailedStartEndResponse? Woodcutting { get; set; }
        public DetailedStartEndResponse? Fletching { get; set; }
        public DetailedStartEndResponse? Fishing { get; set; }
        public DetailedStartEndResponse? Firemaking { get; set; }
        public DetailedStartEndResponse? Crafting { get; set; }
        public DetailedStartEndResponse? Smithing { get; set; }
        public DetailedStartEndResponse? Mining { get; set; }
        public DetailedStartEndResponse? Herblore { get; set; }
        public DetailedStartEndResponse? Agility { get; set; }
        public DetailedStartEndResponse? Thieving { get; set; }
        public DetailedStartEndResponse? Slayer { get; set; }
        public DetailedStartEndResponse? Farming { get; set; }
        public DetailedStartEndResponse? Runecraft { get; set; }
        public DetailedStartEndResponse? Hunter { get; set; }
        public DetailedStartEndResponse? Construction { get; set; }
        public DetailedStartEndResponse? Ehp { get; set; }
        [JsonPropertyName("im_ehp")]
        public DetailedStartEndResponse? ImEhp { get; set; }
        [JsonPropertyName("uim_ehp")]
        public DetailedStartEndResponse? UimEhp { get; set; }
        [JsonPropertyName("lvl3_ehp")]
        public DetailedStartEndResponse? Lvl3Ehp { get; set; }
        [JsonPropertyName("f2p_ehp")]
        public DetailedStartEndResponse? F2pEhp { get; set; }
        [JsonPropertyName("1def_ehp")]
        public DetailedStartEndResponse? OneDefEhp { get; set; }
    }
}
