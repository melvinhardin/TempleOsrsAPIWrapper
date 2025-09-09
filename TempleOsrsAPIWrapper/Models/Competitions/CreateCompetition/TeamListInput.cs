using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition
{
    public class TeamListInput
    {
        public required Dictionary<string, string[]> Teams { get; set; }
        public Dictionary<string,string> ToRequest()
        {
            return Teams.ToDictionary(kvp => kvp.Key, kvp => string.Join(",", kvp.Value));
        }
    }
}
