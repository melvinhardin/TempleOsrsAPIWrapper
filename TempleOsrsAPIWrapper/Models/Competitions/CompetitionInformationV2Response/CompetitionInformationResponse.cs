namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    public class CompetitionInformationResponse
    {
        public InfoResponse? Info { get; set; }
        public ParticipantDetailResponse[]? Participants { get; set; }
        public TeamsResponse? Teams { get; set; }
    }
}
