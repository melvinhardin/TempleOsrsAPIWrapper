namespace TempleOsrsAPIWrapper.Models.Groups
{
    /// <summary>
    /// A help class for building query parameters for group requests.
    /// </summary>
    public class GroupRequest
    {
        /// <summary>
        /// Id of the group.
        /// </summary>
        required public int Id { get; set; }
        /// <summary>
        /// Wether to include bosses in the response.
        /// </summary>
        public bool? IncludeBosses { get; set; }
        /// <summary>
        /// Wether to include skills in the response.
        /// </summary>
        public bool? IncludeSkills { get; set; }
        /// <summary>
        /// Wether to include achievements in the response.
        /// </summary>
        public bool? IncludeAchievements { get; set; }
        /// <summary>
        /// A dictionary representation of the request for use in query parameters.
        /// </summary>
        /// <returns>Returns a dictionary containing the endpoint uri</returns>

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
