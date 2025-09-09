using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    public class TeamDetailResponse
    {
        public string? Name { get; set; }
        [JsonPropertyName("start_xp")]
        public int StartXp { get; set; }
        [JsonPropertyName("end_xp")]

        public int EndXp { get; set; }
        public int Gain { get; set; }
        public string? Mvp { get; set; }
        public List<string>? Members { get; set; }
    }
}
