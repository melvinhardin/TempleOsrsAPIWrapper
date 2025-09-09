using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.CollectionLog
{
    public class CollectionLogMember
    {
        public string? Player { get; set; }
        [JsonPropertyName("player_name_with_capitalization")]
        public string? PlayerNameWithCapitalization { get; set; }
        [JsonPropertyName("last_checked")]
        public string? LastChecked { get; set; }
        [JsonPropertyName("last_changed")]
        public string? LastChanged { get; set; }
        [JsonPropertyName("first_sync")]
        public string? FirstSync { get; set; }
        public float? Ehc { get; set; }
        [JsonPropertyName("ehc_gilded")]
        public float? EhcGilded { get; set; }
        [JsonPropertyName("total_collections_finished")]
        public int? TotalCollectionsFinished { get; set; }
        [JsonPropertyName("total_categories_finished")]
        public int? TotalCategoriesFinished { get; set; }
        public Dictionary<int, int>? Items { get; set; }
    }
}
