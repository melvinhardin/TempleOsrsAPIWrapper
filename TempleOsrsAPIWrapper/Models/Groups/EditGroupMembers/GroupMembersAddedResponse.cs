using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers
{
    /// <summary>
    /// Response model for adding members to a group.
    /// </summary>
    public class GroupMembersAddedResponse
    {
        /// <summary>
        /// The number of names that were successfully added to the group.
        /// </summary>
        [JsonPropertyName("added_names")]
        public int? AddedNames { get; set; }
        /// <summary>
        /// The old number of members in the group before adding new members.
        /// </summary>
        [JsonPropertyName("old_member_count")]
        public int? OldMemberCount { get; set; }
        /// <summary>
        /// The new number of members in the group after adding new members.
        /// </summary>
        [JsonPropertyName("new_member_count")]
        public int? NewMemberCount { get; set; }
    }
}
