using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse
{
    /// <summary>
    /// Skills of a group member.
    /// </summary>
    public class GroupMemberSkills
    {
        /// <summary>
        /// The overall xp.
        /// </summary>
        public uint? Overall { get; set; }
        /// <summary>
        /// The overall level.
        /// </summary>
        [JsonPropertyName("Overall_level")]
        public short? OverallLevel { get; set; }
        /// <summary>
        /// Attack xp.
        /// </summary>
        public int? Attack { get; set; }
        /// <summary>
        /// Attack level.
        /// </summary>
        [JsonPropertyName("Attack_level")]
        public byte? AttackLevel { get; set; }
        /// <summary>
        /// Defence xp.
        /// </summary>
        public int? Defence { get; set; }
        /// <summary>
        /// Defence level.
        /// </summary>
        [JsonPropertyName("Defence_level")]
        public byte? DefenceLevel { get; set; }
        /// <summary>
        /// Strength xp.
        /// </summary>
        public int? Strength { get; set; }
        /// <summary>
        /// Strength level.
        /// </summary>
        [JsonPropertyName("Strength_level")]
        public byte? StrengthLevel { get; set; }
        /// <summary>
        /// Hitpoints xp.
        /// </summary>
        public int? Hitpoints { get; set; }
        /// <summary>
        /// Hitpoints level.
        /// </summary>
        [JsonPropertyName("Hitpoints_level")]
        public byte? HitpointsLevel { get; set; }
        /// <summary>
        /// Ranged xp.
        /// </summary>
        public int? Ranged { get; set; }
        /// <summary>
        /// Ranged level.
        /// </summary>
        [JsonPropertyName("Ranged_level")]
        public byte? RangedLevel { get; set; }
        /// <summary>
        /// Prayer xp.
        /// </summary>
        public int? Prayer { get; set; }
        /// <summary>
        /// Prayer level.
        /// </summary>
        [JsonPropertyName("Prayer_level")]
        public byte? PrayerLevel { get; set; }
        /// <summary>
        /// Magic xp.
        /// </summary>
        public int? Magic { get; set; }
        /// <summary>
        /// Magic level.
        /// </summary>
        [JsonPropertyName("Magic_level")]
        public byte? MagicLevel { get; set; }
        /// <summary>
        /// Cooking xp.
        /// </summary>
        public int? Cooking { get; set; }
        /// <summary>
        /// Cooking level.
        /// </summary>
        [JsonPropertyName("Cooking_level")]
        public byte? CookingLevel { get; set; }
        /// <summary>
        /// Woodcutting xp.
        /// </summary>
        public int? Woodcutting { get; set; }
        /// <summary>
        /// Woodcutting level.
        /// </summary>
        [JsonPropertyName("Woodcutting_level")]
        public byte? WoodcuttingLevel { get; set; }
        /// <summary>
        /// Fletching xp.
        /// </summary>
        public int? Fletching { get; set; }
        /// <summary>
        /// Fletching level.
        /// </summary>
        [JsonPropertyName("Fletching_level")]
        public byte? FletchingLevel { get; set; }
        /// <summary>
        /// Fishing xp.
        /// </summary>
        public int? Fishing { get; set; }
        /// <summary>
        /// Fishing level.
        /// </summary>
        [JsonPropertyName("Fishing_level")]
        public byte? FishingLevel { get; set; }
        /// <summary>
        /// Firemaking xp.
        /// </summary>
        public int? Firemaking { get; set; }
        /// <summary>
        /// Firemaking level.
        /// </summary>
        [JsonPropertyName("Firemaking_level")]
        public byte? FiremakingLevel { get; set; }
        /// <summary>
        /// Crafting xp.
        /// </summary>
        public int? Crafting { get; set; }
        /// <summary>
        /// Creafting level.
        /// </summary>
        [JsonPropertyName("Crafting_level")]
        public byte? CraftingLevel { get; set; }
        /// <summary>
        /// Smithing xp.
        /// </summary>
        public int? Smithing { get; set; }
        /// <summary>
        /// Smithing level.
        /// </summary>
        [JsonPropertyName("Smithing_level")]
        public byte? SmithingLevel { get; set; }
        /// <summary>
        /// Mining xp.
        /// </summary>
        public int? Mining { get; set; }
        /// <summary>
        /// Mining level.
        /// </summary>
        [JsonPropertyName("Mining_level")]
        public byte? MiningLevel { get; set; }
        /// <summary>
        /// Herblore xp.
        /// </summary>
        public int? Herblore { get; set; }
        /// <summary>
        /// Herblore level.
        /// </summary>
        [JsonPropertyName("Herblore_level")]
        public byte? HerbloreLevel { get; set; }
        /// <summary>
        /// Agility xp.
        /// </summary>
        public int? Agility { get; set; }
        /// <summary>
        /// Agility level.
        /// </summary>
        [JsonPropertyName("Agility_level")]
        public byte? AgilityLevel { get; set; }
        /// <summary>
        /// Thieving xp.
        /// </summary>
        public int? Thieving { get; set; }
        /// <summary>
        /// Thieving level.
        /// </summary>
        [JsonPropertyName("Thieving_level")]
        public byte? ThievingLevel { get; set; }
        /// <summary>
        /// Slayer xp.
        /// </summary>
        public int? Slayer { get; set; }
        /// <summary>
        /// Slayer level.
        /// </summary>
        [JsonPropertyName("Slayer_level")]
        public byte? SlayerLevel { get; set; }
        /// <summary>
        /// Farming xp.
        /// </summary>
        public int? Farming { get; set; }
        /// <summary>
        /// Farming level.
        /// </summary>
        [JsonPropertyName("Farming_level")]
        public byte? FarmingLevel { get; set; }
        /// <summary>
        /// Runecraft xp.
        /// </summary>
        public int? Runecraft { get; set; }
        /// <summary>
        /// Runecraft level.
        /// </summary>
        [JsonPropertyName("Runecraft_level")]
        public byte? RunecraftLevel { get; set; }
        /// <summary>
        /// Hunter xp.
        /// </summary>
        public int? Hunter { get; set; }
        /// <summary>
        /// Hunter level.
        /// </summary>
        [JsonPropertyName("Hunter_level")]
        public byte? HunterLevel { get; set; }
        /// <summary>
        /// Construction xp.
        /// </summary>
        public int? Construction { get; set; }
        /// <summary>
        /// Construction level.
        /// </summary>
        [JsonPropertyName("Construction_level")]
        public byte? ConstructionLevel { get; set; }
        /// <summary>
        /// Effective hours played.
        /// </summary>
        public float? Ehp { get; set; }
    }
}
