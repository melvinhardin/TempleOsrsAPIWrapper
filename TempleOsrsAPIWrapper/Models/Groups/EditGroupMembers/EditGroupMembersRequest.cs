using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers
{
    /// <summary>
    /// Edit members of a group request model.
    /// </summary>
    public class EditGroupMembersRequest
    {
        /// <summary>
        /// id of the group to edit members for.
        /// </summary>

        [JsonPropertyName("id")]
        required public int Id { get; set; }
        /// <summary>
        /// The private key of the group to edit members for.
        /// </summary>
        [JsonPropertyName("key")]
        required public string Key { get; set; }
        /// <summary>
        /// a JSON-encoded string of the list of players to add or remove.
        /// </summary>
        [JsonPropertyName("players")]
        required public string Players { get; set; }
    }
}
