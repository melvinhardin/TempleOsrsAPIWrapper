using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    /// <summary>
    /// A model representing the input for team lists when creating a team competition.
    /// </summary>
    public class TeamListInput
    {
        /// <summary>
        /// The teams to be included in the competition, where the key is the team name and the value is an array of player names.
        /// </summary>
        public required Dictionary<string, string[]> Teams { get; set; }
        /// <summary>
        /// A method to convert the team list into a format suitable for API requests.
        /// </summary>
        public Dictionary<string,string> ToRequest()
        {
            return Teams.ToDictionary(kvp => kvp.Key, kvp => string.Join(",", kvp.Value));
        }
    }
}
