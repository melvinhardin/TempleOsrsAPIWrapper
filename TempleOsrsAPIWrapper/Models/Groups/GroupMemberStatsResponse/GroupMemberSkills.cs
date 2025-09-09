using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse
{
    public class GroupMemberSkills
    {
        public uint? Overall { get; set; }
        [JsonPropertyName("Overall_level")]
        public short? OverallLevel { get; set; }
        public int? Attack { get; set; }
        [JsonPropertyName("Attack_level")]
        public byte? AttackLevel { get; set; }
        public int? Defence { get; set; }
        [JsonPropertyName("Defence_level")]
        public byte? DefenceLevel { get; set; }
        public int? Strength { get; set; }
        [JsonPropertyName("Strength_level")]
        public byte? StrengthLevel { get; set; }
        public int? Hitpoints { get; set; }
        [JsonPropertyName("Hitpoints_level")]
        public byte? HitpointsLevel { get; set; }
        public int? Ranged { get; set; }
        [JsonPropertyName("Ranged_level")]
        public byte? RangedLevel { get; set; }
        public int? Prayer { get; set; }
        [JsonPropertyName("Prayer_level")]
        public byte? PrayerLevel { get; set; }
        public int? Magic { get; set; }
        [JsonPropertyName("Magic_level")]
        public byte? MagicLevel { get; set; }
        public int? Cooking { get; set; }
        [JsonPropertyName("Cooking_level")]
        public byte? CookingLevel { get; set; }
        public int? Woodcutting { get; set; }
        [JsonPropertyName("Woodcutting_level")]
        public byte? WoodcuttingLevel { get; set; }
        public int? Fletching { get; set; }
        [JsonPropertyName("Fletching_level")]
        public byte? FletchingLevel { get; set; }
        public int? Fishing { get; set; }
        [JsonPropertyName("Fishing_level")]
        public byte? FishingLevel { get; set; }
        public int? Firemaking { get; set; }
        [JsonPropertyName("Firemaking_level")]
        public byte? FiremakingLevel { get; set; }
        public int? Crafting { get; set; }
        [JsonPropertyName("Crafting_level")]
        public byte? CraftingLevel { get; set; }
        public int? Smithing { get; set; }
        [JsonPropertyName("Smithing_level")]
        public byte? SmithingLevel { get; set; }
        public int? Mining { get; set; }
        [JsonPropertyName("Mining_level")]
        public byte? MiningLevel { get; set; }
        public int? Herblore { get; set; }
        [JsonPropertyName("Herblore_level")]
        public byte? HerbloreLevel { get; set; }
        public int? Agility { get; set; }
        [JsonPropertyName("Agility_level")]
        public byte? AgilityLevel { get; set; }
        public int? Thieving { get; set; }
        [JsonPropertyName("Thieving_level")]
        public byte? ThievingLevel { get; set; }
        public int? Slayer { get; set; }
        [JsonPropertyName("Slayer_level")]
        public byte? SlayerLevel { get; set; }
        public int? Farming { get; set; }
        [JsonPropertyName("Farming_level")]
        public byte? FarmingLevel { get; set; }
        public int? Runecraft { get; set; }
        [JsonPropertyName("Runecraft_level")]
        public byte? RunecraftLevel { get; set; }
        public int? Hunter { get; set; }
        [JsonPropertyName("Hunter_level")]
        public byte? HunterLevel { get; set; }
        public int? Construction { get; set; }
        [JsonPropertyName("Construction_level")]
        public byte? ConstructionLevel { get; set; }
        public float? Ehp { get; set; }
    }
}
