namespace TempleOsrsAPIWrapper.Models.Common
{
    public class RootResponse<T>
    {
        /// <summary>
        /// Data will contain the main response object, if the request was successful. If the request was not successful, this will be null.
        /// </summary>
        public T? Data { get; set; }
    }
}
