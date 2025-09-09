using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.EditGroupMembers
{
    public class EditGroupMembersRequest
    {

        [JsonPropertyName("id")]
        required public int Id { get; set; }
        [JsonPropertyName("key")]
        required public string Key { get; set; }
        [JsonPropertyName("players")]
        required public string Players { get; set; }
    }
}
