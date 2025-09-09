using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.CollectionLog
{
    public class CollectionLogGroupResponse
    {
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }
        [JsonPropertyName("group_name")]
        public string? GroupName { get; set; }
        [JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }
        [JsonPropertyName("members_with_items_synced")]
        public int? MembersWithItemsSynced { get; set; }
        [JsonPropertyName("total_collections_available")]
        public int? TotalCollectionsAvailable { get; set; }
        [JsonPropertyName("total_categories_available")]
        public int? TotalCategoriesAvailable { get; set; }
        public CollectionLogMember[]? Members { get; set; }
        public string? Categories { get; set; }
    }
}
