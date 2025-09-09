using Microsoft.AspNetCore.WebUtilities;
using TempleOsrsAPIWrapper.Models.CollectionLog;
using TempleOsrsAPIWrapper.Models.Common;
using TempleOsrsAPIWrapper.Utils;

namespace TempleOsrsAPIWrapper.http
{
    /// <summary>
    /// Contains all methods related to the <a href="https://templeosrs.com/api_doc.php#Clog_Endpoints">TempleOsrs collection log endpoints. </a> Uses the <see cref="HttpClient"/> setup in the HttpRequestHandler.
    /// </summary>
    public class TempleOsrsCollectionApiClientService
    {
        private readonly HttpRequestHandler _httpRequestHandler;

        public TempleOsrsCollectionApiClientService(HttpRequestHandler httpRequestHandler)
        {
            _httpRequestHandler = httpRequestHandler;
        }
        /// <summary>
        /// Gets all collection logs for a specific group.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <returns>Returns A <see cref="RootResponse{T}"/> containing a <see cref="CollectionLogGroupResponse"/>.</returns>
        public async Task<RootResponse<CollectionLogGroupResponse>?> GetGroupCollections(int groupId)
        {
            var query = new CollectionLogRequests
            {
                Group = groupId,
                Includecount = true,
                Categories = ["all"]
            };
            string uri = QueryHelpers.AddQueryString("collection-log/group_collection_log.php", query.CollectionLogRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<CollectionLogGroupResponse>>(uri);
        }
    }
}

