namespace TempleOsrsAPIWrapper.Models.Player.PlayerNamesResponse
{
    public class PlayerNamesResponse
    {
        public Dictionary<string, AliasResponse?>? Aliases { get; set; }
        public List<HistoryResponse?>? History { get; set; }
        public InfoResponse? Info { get; set; }
    }
}
