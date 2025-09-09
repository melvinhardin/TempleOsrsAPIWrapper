namespace TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse
{
    /// <summary>
    /// Model for the response of group member stats.
    /// </summary>
    public class GroupMemberStatsResponse
    {
        /// <summary>
        /// A dictionary where the key is the member's RSN and the value is their corresponding <see cref="GroupMemberStats"/>.
        /// </summary>
        public Dictionary<string, GroupMemberStats>? Memberlist { get; set; }
    }
}
