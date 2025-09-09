using Microsoft.AspNetCore.WebUtilities;
using TempleOsrsAPIWrapper.Models.Common;
using TempleOsrsAPIWrapper.Models.Competitions;
using TempleOsrsAPIWrapper.Models.Competitions.AddCompetitionPlayer;
using TempleOsrsAPIWrapper.Models.Competitions.CompetitionInformationV2Response;
using TempleOsrsAPIWrapper.Models.Competitions.CreateCompetition;
using TempleOsrsAPIWrapper.Models.Competitions.DeleteCompetition;
using TempleOsrsAPIWrapper.Models.Competitions.RemoveCompetitionPlayer;
using TempleOsrsAPIWrapper.Utils;

namespace TempleOsrsAPIWrapper.http
{
    /// <summary>
    /// Contains all methods related to the <a href="https://templeosrs.com/api_doc.php#Competition_Endpoints">TempleOsrs competition endpoints. </a> Uses the <see cref="HttpClient"/> setup in the HttpRequestHandler.
    /// </summary>
    public class TempleOsrsCompetitionApiClientService
    {
        private readonly HttpRequestHandler _httpRequestHandler;

        public TempleOsrsCompetitionApiClientService(HttpRequestHandler httpRequestHandler)
        {
            _httpRequestHandler = httpRequestHandler;
        }
        /// <summary>
        /// Retrieves a list of players in a competition.
        /// </summary>
        /// <param name="competitionId">The competition id.</param>
        /// <returns>A list containing each player in the competition</returns>
        public async Task<List<string>?> GetCompetitionMembers(int competitionId)
        {
            var query = new CompetitionRequest
            {
                Id = competitionId
            };
            string uri = QueryHelpers.AddQueryString("compmembers.php", query.CompetitionRequestQueryDict());
            return await _httpRequestHandler.GetRequestUnwrapped<List<string>>(uri);
        }
        /// <summary>
        /// Retrieves detailed information about the competition, defaults to chosen skill if none is provided.
        /// </summary>
        /// <param name="competitionId">The competition id.</param>
        /// <param name="skill">A string for the skill to get details for. Either lowercase skill/boss name, or number . Details can be found on <a href="https://templeosrs.com/js/skill_data.js"> https://templeosrs.com/js/skill_data.js</a></param>
        /// <param name="details"></param>
        /// <returns>Returns A <see cref="RootResponse{T}"/> containing a <see cref="CompetitionInformationResponse"/>.</returns>
        public async Task<RootResponse<CompetitionInformationResponse>?> GetCompetitionInfo(int competitionId, string? skill = null, bool details = false)
        {
            var query = new CompetitionRequest
            {
                Id = competitionId,
                Skill = skill,
                Details = details
            };
            string uri = QueryHelpers.AddQueryString("competition_info_v2.php", query.CompetitionRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<CompetitionInformationResponse>>(uri);
        }
        /// <summary>
        /// Creates a new competition for individuals.
        /// </summary>
        /// <param name="newCompetition"> Takes the name, skill, starting date (unix), ending date(unix), and a string list of participants in the form of an object <see cref="CreateCompetitionStandardRequest"></see></param>
        /// <returns>Returns A <see cref="CreateCompetitionResponse"/> model</returns>
        public async Task<RootResponse<CreateCompetitionResponse>?> CreateCompetition(CreateCompetitionStandardRequest newCompetition)
        {
            string uri = "competition_create.php";
            return await _httpRequestHandler.PostRequestModel<CreateCompetitionStandardRequest, RootResponse<CreateCompetitionResponse>>(uri, newCompetition);
        }
        /// <summary>
        /// Creates a new team competition.
        /// </summary>
        /// <param name="newTeamCompetition">Takes the name, skill, starting date (unix), ending date(unix), and a dictionary with teamname as key and a list of participants in the form of an object <see cref="CreateCompetitionTeamRequest"></see></param>
        /// <returns>Returns A <see cref="CreateCompetitionResponse"/> model</returns>
        public async Task<RootResponse<CreateCompetitionResponse>?> CreateCompetition(CreateCompetitionTeamRequest newTeamCompetition)
        {
            string uri = "competition_create.php";
            return await _httpRequestHandler.PostRequestModel<CreateCompetitionTeamRequest, RootResponse<CreateCompetitionResponse>>(uri, newTeamCompetition);
        }
        /// <summary>
        /// Removes a competition
        /// </summary>
        /// <param name="competitionId">The competition id.</param>
        /// <param name="competitionKey">The secret competition key.</param>
        /// <returns>Returns A <see cref="RootResponse{T}"/> containing a <see cref="DeleteCompetitionResponse"/>.</returns>
        public async Task<RootResponse<DeleteCompetitionResponse>?> DeleteCompetition(int competitionId, string competitionKey)
        {
            var content = new DeleteCompetitionRequest
            {
                Id = competitionId,
                Key = competitionKey
            };
            string uri = "competition_delete.php";
            return await _httpRequestHandler.PostRequestModel<DeleteCompetitionRequest,RootResponse<DeleteCompetitionResponse>>(uri, content);
        }
        /// <summary>
        /// Adds a list of player(s) to the given competition id.
        /// </summary>
        /// <param name="competitionId">The competition id.</param>
        /// <param name="playersList">A list containing player names to add to the competition.</param>
        /// <param name="competitionKey">The secret competition key.</param>
        /// <returns>Returns A <see cref="RootResponse{T}"/> containing a <see cref="AddCompetitonPlayerResponse"/>.</returns>
        public async Task<RootResponse<AddCompetitonPlayerResponse>?> AddCompetitionPlayers(int competitionId, string[] playersList, string competitionKey)
        {
            string players = string.Join(", ", playersList);
            var content = new AddCompetitionPlayerRequest
            {
                Id = competitionId,
                Players = players,
                Key = competitionKey
            };
            string uri = "competition_add_participant.php";
            return await _httpRequestHandler.PostRequestModel<AddCompetitionPlayerRequest, RootResponse<AddCompetitonPlayerResponse>>(uri, content);
        }
        /// <summary>
        /// Adds a list of player(s) to the given competition id.
        /// </summary>
        /// <param name="competitionId">The competition id.</param>
        /// <param name="playersList">A list containing player names to remove to the competition.</param>
        /// <param name="competitionKey">The secret competition key.</param>
        /// <returns>Returns A <see cref="RootResponse{T}"/> containing a <see cref="RemoveCompetitionPlayerResponse"/>.</returns>
        public async Task<RootResponse<RemoveCompetitionPlayerResponse>?> RemoveCompetitionPlayers(int competitionId, string[] playersList, string competitionKey)
        {
            string players = string.Join(", ", playersList);
            var content = new RemoveCompetitionPlayerRequest
            {
                Id = competitionId,
                Players = players,
                Key = competitionKey
            };
            string uri = "competition_remove_participant.php";
            return await _httpRequestHandler.PostRequestModel<RemoveCompetitionPlayerRequest, RootResponse<RemoveCompetitionPlayerResponse>>(uri, content);
        }
    }
}
