using Microsoft.AspNetCore.WebUtilities;
using TempleOsrsAPIWrapper.Models.Common;
using TempleOsrsAPIWrapper.Models.Groups;
using TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers;
using TempleOsrsAPIWrapper.Models.Groups.GroupInformationAchievementResponse;
using TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse;
using TempleOsrsAPIWrapper.Models.Groups.GroupRecentMilestones;
using TempleOsrsAPIWrapper.Utils;

namespace TempleOsrsAPIWrapper.http
{
    /// <summary>
    /// Contains all methods related to the <a href="https://templeosrs.com/api_doc.php#Group_Endpoints">TempleOsrs group endpoints</a>. Uses the <see cref="HttpClient"/> setup in the HttpRequestHandler.
    /// </summary>
    public class TempleOsrsGroupApiClientService
    {
        private readonly HttpRequestHandler _httpRequestHandler;

        public TempleOsrsGroupApiClientService(HttpRequestHandler httpRequestHandler)
        {
            _httpRequestHandler = httpRequestHandler;
        }
        /// <summary>
        /// Retrieves a list of all RSN's in a group
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <returns>Returns a list containing users that belong to given group id.</returns>
        public async Task<List<string>?> GetGroupMembers(int groupId)
        {
            var query = new GroupRequest
            {
                Id = groupId
            };
            string uri = QueryHelpers.AddQueryString("groupmembers.php", query.GroupRequestQueryDict());
            return await _httpRequestHandler.GetRequestUnwrapped<List<string>>(uri);
        }

        /// <summary>
        /// Retrieves player information for each group member, optionally retrieves skill and boss data.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <param name="includeSkills">Whether to include skills.</param>
        /// <param name="includeBosses">Whether to include bosses.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="GroupMemberStatsResponse"/>.</returns>
        public async Task<RootResponse<GroupMemberStatsResponse>?> GetGroupMemberStats(int groupId, bool? includeSkills = null, bool? includeBosses = null)
        {
            var query = new GroupRequest
            {
                Id = groupId,
                IncludeSkills = includeSkills,
                IncludeBosses = includeBosses
            };
            string uri = QueryHelpers.AddQueryString("group_member_info.php", query.GroupRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<GroupMemberStatsResponse>>(uri);
        }
        /// <summary>
        /// Retrieves group information, including achievements.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="GroupInformationAchievementResponse"/>.</returns>
        public async Task<RootResponse<GroupInformationAchievementResponse>?> GetGroupAchievementInformation(int groupId)
        {
            var query = new GroupRequest
            {
                Id = groupId,
                IncludeAchievements = true,
            };
            string uri = QueryHelpers.AddQueryString("group_info.php", query.GroupRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<GroupInformationAchievementResponse>>(uri);
        }
        /// <summary>
        /// Retrieves recent milestones for each group member.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a list of <see cref="UserMilestone[]"/>.</returns>
        public async Task<RootResponse<UserMilestone[]>?> GetGroupRecentMilestones(int groupId)
        {
            var query = new GroupRequest
            {
                Id = groupId,
            };
            string uri = QueryHelpers.AddQueryString("group_achievements.php", query.GroupRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<UserMilestone[]>>(uri);
        }
        /// <summary>
        /// Retrieves all competitions linked to the group.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a list of <see cref="GroupCompetitions[]"/>.</returns>
        public async Task<RootResponse<GroupCompetitions[]>?> GetGroupCompetitions(int groupId)
        {
            var query = new GroupRequest
            {
                Id = groupId,
            };
            string uri = QueryHelpers.AddQueryString("group_competitions.php", query.GroupRequestQueryDict());
            return await _httpRequestHandler.GetRequest<RootResponse<GroupCompetitions[]>>(uri);
        }
        /// <summary>
        /// Removes members from a group. Requires the group key.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <param name="playersList">A list of players to remove.</param>
        /// <param name="groupKey">The private group key.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="GroupMembersRemovedResponse"/>.</returns>
        public async Task<RootResponse<GroupMembersRemovedResponse>?> RemoveGroupMembers(int groupId, string[] playersList, string groupKey)
        {
            string players = string.Join(", ", playersList);
            var content = new EditGroupMembersRequest
            {
                Id = groupId,
                Players = players,
                Key = groupKey
            };
            string uri = "remove_group_member.php";
            return await _httpRequestHandler.PostRequestModel<EditGroupMembersRequest, RootResponse<GroupMembersRemovedResponse>>(uri, content);
        }
        /// <summary>
        /// Adds members to a group. Requires the group key.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <param name="playersList">A list of players to remove.</param>
        /// <param name="groupKey">The private group key.</param>
        /// <returns>A <see cref="RootResponse{T}"/> containing a <see cref="GroupMembersAddedResponse"/>.</returns>
        public async Task<RootResponse<GroupMembersAddedResponse>?> AddGroupMembers(int groupId, string[] playersList, string groupKey)
        {
            string players = string.Join(", ", playersList);
            var content = new EditGroupMembersRequest
            {
                Id = groupId,
                Players = players,
                Key = groupKey
            };
            string uri = "add_group_member.php";
            return await _httpRequestHandler.PostRequestModel<EditGroupMembersRequest, RootResponse<GroupMembersAddedResponse>>(uri, content);
        }
    }
}
