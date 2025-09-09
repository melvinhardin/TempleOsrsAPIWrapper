using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    public class DetailedStartEndResponse
    {
        [JsonPropertyName("start_xp")]
        public int Start { get; set; }
        [JsonPropertyName("end_xp")]
        public int End { get; set; }
    }
}
