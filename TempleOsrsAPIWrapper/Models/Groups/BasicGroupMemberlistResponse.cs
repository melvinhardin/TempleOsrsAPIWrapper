namespace TempleOsrsAPIWrapper.Models.Groups
{
    /// <summary>
    /// Model for the response from the group memberlist endpoint.
    /// </summary>
    public class BasicGroupMemberlistResponse
    {
        /// <summary>
        /// list of group members' RSN's.
        /// </summary>
        public string[]? MemberList { get; set; }
        public static BasicGroupMemberlistResponse FromArray(string[] data)
        {
            return new BasicGroupMemberlistResponse { MemberList = data };
        }
    }
}
