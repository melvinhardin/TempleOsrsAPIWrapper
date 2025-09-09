namespace TempleOsrsAPIWrapper.Models.Groups
{
    public class BasicGroupMemberlistResponse
    {
        public String[]? MemberList { get; set; }
        public static BasicGroupMemberlistResponse FromArray(string[] data)
        {
            return new BasicGroupMemberlistResponse { MemberList = data };
        }
    }
}
