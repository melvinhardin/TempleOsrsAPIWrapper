namespace TempleOsrsAPIWrapper.Models.Groups.GroupRecentMilestones
{
    /// <summary>
    /// Model representing a user milestone in a group.
    /// </summary>
    public class UserMilestone
    {
        /// <summary>
        /// Player's RSN.
        /// </summary>
        public string? username { get; set; }
        /// <summary>
        /// Date of the milestone in YYYY-MM-DD format.
        /// </summary>
        public string? Date { get; set; }
        /// <summary>
        /// Skill associated with the milestone.
        /// </summary>
        public string? Skill { get; set; }
        /// <summary>
        /// Type of milestone (e.g., level, xp).
        /// </summary>
        public string? Milestone { get; set; }
        /// <summary>
        /// Type of the skill of the milestone.
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// The xp or kc of the milestone.
        /// </summary>
        public long? Xp { get; set; }
    }
}
