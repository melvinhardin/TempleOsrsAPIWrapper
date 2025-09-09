using Microsoft.AspNetCore.WebUtilities;
using TempleOsrsAPIWrapper.Models.CollectionLog;
using TempleOsrsAPIWrapper.Models.Common;
using TempleOsrsAPIWrapper.Utils;

namespace TempleOsrsAPIWrapper.http
{
    public class TempleOsrsCollectionApiClientService
    {
        private readonly HttpRequestHandler _httpRequestHandler;

        public TempleOsrsCollectionApiClientService(HttpRequestHandler httpRequestHandler)
        {
            _httpRequestHandler = httpRequestHandler;
        }

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

