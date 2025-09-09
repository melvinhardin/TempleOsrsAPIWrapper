namespace TempleOsrsAPIWrapper.Models.Player
{
    public class PlayerRequest
    {
        required public string Player { get; set; }
        public bool? IncludeCollectionLogInfo { get; set; }
        public bool? FormattedOsrsName { get; set; }
        public long? Date { get; set; }
        public bool? IncludeBosses { get; set; }
        public long? Time { get; set; }

        public Dictionary<string, string?> PlayerRequestQueryDict()
        {
            var dict = new Dictionary<string, string?>();
            if (!string.IsNullOrEmpty(Player))
                dict["player"] = Player;
            if (IncludeCollectionLogInfo.HasValue)
                dict["cloginfo"] = IncludeCollectionLogInfo.Value ? "1" : "0";
            if (FormattedOsrsName.HasValue)
                dict["formattedrsn"] = FormattedOsrsName.Value ? "1" : "0";
            if (Date > 0)
                dict["date"] = Date.Value.ToString();
            if (IncludeBosses.HasValue)
                dict["bosses"] = IncludeBosses.Value ? "1" : "0";
            if (Time > 0)
                dict["time"] = Time.Value.ToString();
            return dict;
        }
    }
}
