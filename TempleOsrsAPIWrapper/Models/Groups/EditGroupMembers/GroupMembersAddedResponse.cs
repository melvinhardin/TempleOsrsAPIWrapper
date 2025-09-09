using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers
{
    public class GroupMembersAddedResponse
    {
        [JsonPropertyName("added_names")]
        public int? AddedNames { get; set; }
        [JsonPropertyName("old_member_count")]
        public int? OldMemberCount { get; set; }
        [JsonPropertyName("new_member_count")]
        public int? NewMemberCount { get; set; }
    }
}
