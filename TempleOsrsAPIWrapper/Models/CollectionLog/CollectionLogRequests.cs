namespace TempleOsrsAPIWrapper.Models.CollectionLog
{
    public class CollectionLogRequests
    {
        public required int Group { set; get; }
        public required string[]? Categories { set; get; }
        public bool Includecount { set; get; }
        public Dictionary<string, string?> CollectionLogRequestQueryDict()
        {
            var dict = new Dictionary<string, string?>();
            string? CategoriesString = null;
            if (Categories != null)
                CategoriesString = string.Join(",", Categories);
            if (Group > 0)
                dict["group"] = Group.ToString();
            if (!string.IsNullOrEmpty(CategoriesString))
                dict["categories"] = CategoriesString.ToString();
            if (Includecount)
                dict["includecount"] = "1";
            return dict;
        }
    }
}
