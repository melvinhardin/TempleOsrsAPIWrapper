namespace TempleOsrsAPIWrapper.Models.Groups.GroupInformationAchievementResponse
{
    /// <summary>
    /// The response model for group information including achievements.
    /// </summary>
    public class GroupInformationAchievementResponse
    {
        /// <summary>
        /// General information model about the group.
        /// </summary>
        public GroupInfo? Info { get; set; }
        /// <summary>
        /// A dictionary of members of the group, with the key being the member's RSN and the value being a <see cref="DetailedGroupMember"/> object containing detailed information about the member.
        /// </summary>
        public Dictionary<string, DetailedGroupMember>? Members { get; set; }
        /// <summary>
        /// A dictionary of leaders of the group, with the key being the member's RSN and the value being a <see cref="DetailedGroupMember"/> object containing detailed information about the member.
        /// </summary>
        public Dictionary<string, DetailedGroupMember>? Leaders { get; set; }
    }
}