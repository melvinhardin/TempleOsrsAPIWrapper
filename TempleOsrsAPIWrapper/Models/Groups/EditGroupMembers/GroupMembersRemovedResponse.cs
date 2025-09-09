using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers
{
    public class GroupMembersRemovedResponse
    {
        [JsonPropertyName("removed_names")]
        public int RemovedNames { get; set; }
        [JsonPropertyName("old_member_count")]
        public int OldMemberCount { get; set; }
        [JsonPropertyName("new_member_count")]
        public int NewMemberCount { get; set; }

    }
}
