namespace TempleOsrsAPIWrapper.Models.Groups.GroupInformationAchievementResponse;
public class GroupInformationAchievementResponse
{
    public GroupInfo? Info { get; set; }
    public Dictionary<string, DetailedGroupMember>? Members { get; set; }
    public Dictionary<string, DetailedGroupMember>? Leaders { get; set; }
}
