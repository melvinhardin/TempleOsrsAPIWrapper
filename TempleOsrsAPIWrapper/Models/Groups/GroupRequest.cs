namespace TempleOsrsAPIWrapper.Models.Groups
{
    public class GroupRequest
    {
        required public int Id { get; set; }
        public bool? IncludeBosses { get; set; }
        public bool? IncludeSkills { get; set; }
        public bool? IncludeAchievements { get; set; }

        public Dictionary<string, string?> GroupRequestQueryDict()
        {
            var dict = new Dictionary<string, string?>();
            if (Id > 0)
                dict["id"] = Id.ToString();
            if (IncludeBosses.HasValue)
                dict["bosses"] = "1";
            if (IncludeSkills.HasValue)
                dict["skills"] = "1";
            if (IncludeAchievements.HasValue)
                dict["achievements"] = "1";
            return dict;
        }
    }
}
