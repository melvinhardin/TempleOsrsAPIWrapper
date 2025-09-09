using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers
{
    public class GroupMembersRemovedResponse
    {
        /// <summary>
        /// The ammmount of names removed from the group.
        /// </summary>
        [JsonPropertyName("removed_names")]
        public int RemovedNames { get; set; }
        /// <summary>
        /// The old number of members in the group before removing members.
        /// </summary>
        [JsonPropertyName("old_member_count")]
        public int OldMemberCount { get; set; }
        /// <summary>
        /// The new number of members in the group after removing members.
        /// </summary>
        [JsonPropertyName("new_member_count")]
        public int NewMemberCount { get; set; }

    }
}
