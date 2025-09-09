namespace TempleOsrsAPIWrapper.Models.Competitions
{
    /// <summary>
    /// A help class for building query parameters for competition requests.
    /// </summary>
    public class CompetitionRequest
    {
        /// <summary>
        /// The competition id.
        /// </summary>
        required public int Id { get; set; }
        /// <summary>
        /// If provided, filters competitions by the specified skill or boss. Either lowercase skill/boss name, or number . Details can be found on <a href="https://templeosrs.com/js/skill_data.js"> https://templeosrs.com/js/skill_data.js</a>
        /// </summary>
        public string? Skill { get; set; }
        /// <summary>
        /// A boolean indicating if detailed information should be returned. Defaults to false.
        /// </summary>
        public bool Details { get; set; }
        /// <summary>
        /// The dictionary representation of the request for use in query parameters.
        /// </summary>
        /// <returns></returns>
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
