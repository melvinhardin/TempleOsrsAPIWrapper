using Microsoft.AspNetCore.WebUtilities;
using TempleOsrsAPIWrapper.Models.Common;
using TempleOsrsAPIWrapper.Models.Player;
using TempleOsrsAPIWrapper.Models.Player.PlayerDatapointsResponse;
using TempleOsrsAPIWrapper.Models.Player.PlayerInformationResponse;
using TempleOsrsAPIWrapper.Models.Player.PlayerNamesResponse;
using TempleOsrsAPIWrapper.Models.Player.PlayerStatsResponse;
using TempleOsrsAPIWrapper.Utils;

namespace TempleOsrsAPIWrapper.http
{
    /// <summary>
    /// Contains all methods related to the <a href="https://templeosrs.com/api_doc.php#Player_Endpoints">TempleOsrs player endpoints. </a> Uses the <see cref="HttpClient"/> setup in the HttpRequestHandler.
    /// </summary>
    public class TempleOsrsUserApiClientService
    {
        private readonly HttpRequestHandler _httpRequestHandler;

        public TempleOsrsUserApiClientService(HttpRequestHandler httpRequestHandler)
        {
            _httpRequestHandler = httpRequestHandler;
        }
        /// <summary>
        /// Retrieves player data based on player name. Optionally includes boss data and historical data via unix timestamp.
        /// </summary>
        /// <param name="player">The player name</param>
        /// <param name="bosses">Whether to include bosses, defaults to <c>false</c></param>
        /// <param name="date">Optional unix timestamp for historical data, defaults to most recent datapoint if not provided</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="PlayerStatResponse"/>.</returns>
        public async Task<RootResponse<PlayerStatResponse>?> GetPlayerStats(string player, bool bosses = false, long date = 0)
        {
            var query = new PlayerRequest
            {
                Player = player,
                IncludeBosses = bosses,
                Date = date
            };
            string uri = QueryHelpers.AddQueryString("player_stats.php", query.PlayerRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<PlayerStatResponse>>(uri);
        }
        /// <summary>
        /// Retrieves players information regarding last temple sync. Optionally includes syncdata on the collectionlog and their formatted RSN.
        /// </summary>
        /// <param name="player">The player name</param>
        /// <param name="cloginfo">Whether to include collectionlog sync information</param>
        /// <param name="formattedrsn">Whether to include the formatted RNS</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="PlayerInformationResponse"/>.</returns>
        public async Task<RootResponse<PlayerInformationResponse>?> GetPlayerInformation(string player, bool cloginfo = false, bool formattedrsn = false)
        {
            var query = new PlayerRequest
            {
                Player = player,
                IncludeCollectionLogInfo = cloginfo,
                FormattedOsrsName = formattedrsn
            };
            string uri = QueryHelpers.AddQueryString("player_info.php", query.PlayerRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<PlayerInformationResponse>>(uri);
        }
        /// <summary>
        /// Retrieves all historical ingame player names linked to the current RSN.
        /// </summary>
        /// <param name="player">The player name</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="PlayerNamesResponse"/>.</returns>
        public async Task<RootResponse<PlayerNamesResponse>?> GetPlayerNames(string player)
        {
            var query = new PlayerRequest
            { 
                Player = player 
            };
            string uri = QueryHelpers.AddQueryString("player/player_names.php", query.PlayerRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<PlayerNamesResponse>>(uri);
        }
        /// <summary>
        /// Retrieves all gained xp over a timespan. Optionally includes bossdata.
        /// </summary>
        /// <param name="player">The player name</param>
        /// <param name="time">Seconds since current time to retrieve gains from</param>
        /// <param name="bosses">Whether to include bossdata</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="PlayerGainsResponse"/>.</returns>
        public async Task<RootResponse<PlayerGainsResponse>?> GetPlayerGains(string player, long time, bool bosses = false)
        {
            var query = new PlayerRequest
            {
                Player = player,
                Time = time,
                IncludeBosses = bosses
            };
            string uri = QueryHelpers.AddQueryString("player_gains.php", query.PlayerRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<PlayerGainsResponse>>(uri);
        }
        /// <summary>
        /// Retrieves the last 200 skill datapoints made.
        /// </summary>
        /// <param name="player">The player name</param>
        /// <param name="time">Time in seconds before now.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="DatapointSkillResponse"/>.</returns>
        public async Task<RootResponse<Dictionary<string, DatapointSkillResponse>>?> GetPlayerSkillDatapoints(string player, long time)
        {
            var query = new PlayerRequest
            {
                Player = player,
                Time = time
            };
            string uri = QueryHelpers.AddQueryString("player_datapoints.php", query.PlayerRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<Dictionary<string, DatapointSkillResponse>>>(uri);

        }
        /// <summary>
        /// Retrieves the last 200 boss datapoints made.
        /// </summary>
        /// <param name="player">The player name</param>
        /// <param name="time">Time in seconds before now.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="DatapointBossResponse"/>.</returns>
        public async Task<RootResponse<PlayerDatapointsResponse<DatapointBossResponse>>?> GetPlayerBossDatapoints(string player, long time)
        {
            var query = new PlayerRequest
            {
                Player = player,
                Time = time,
                IncludeBosses = true
            };
            string uri = QueryHelpers.AddQueryString("player_datapoints.php", query.PlayerRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<PlayerDatapointsResponse<DatapointBossResponse>>>(uri);
        }
    }
}

