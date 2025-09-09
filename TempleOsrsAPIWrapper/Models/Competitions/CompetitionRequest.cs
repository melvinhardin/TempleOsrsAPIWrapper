namespace TempleOsrsAPIWrapper.Models.Competitions
{
    public class CompetitionRequest
    {
        required public int Id { get; set; }
        public string? Skill { get; set; }
        public bool Details { get; set; }

        public Dictionary<string, string?> CompetitionRequestQueryDict()
        {
            var dict = new Dictionary<string, string?>();
            if (Id > 0)
                dict["id"] = Id.ToString();
            if (!string.IsNullOrEmpty(Skill))
                dict["skill"] = Skill;
            if (Details)
                dict["details"] = Details.ToString();
            return dict;
        }
    }
}
