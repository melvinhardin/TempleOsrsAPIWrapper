namespace TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response
{
    /// <summary>
    /// Response containing detailed information about a competition, including general information,
    /// participants, and teams.
    /// </summary>
    /// <remarks>This class is used to encapsulate the data returned
    /// The properties of this class may be null  if the corresponding data is
    /// not available.</remarks>
    public class CompetitionInformationResponse
    {
        public InfoResponse? Info { get; set; }
        public ParticipantDetailResponse[]? Participants { get; set; }
        public TeamsResponse? Teams { get; set; }
    }
}
