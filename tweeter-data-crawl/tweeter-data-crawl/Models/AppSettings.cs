using Newtonsoft.Json;

namespace tweeter_data_crawl.Models
{
    public class AppSettings
    {
        public string MainUserName { get; set; }
        public Consumer Consumer { get; set; }
        public string AuthorizeToken { get; set; }
    }

    /// <summary>
    /// https://developer.twitter.com/en/apps/APP_ID
    /// </summary>
    public class Consumer
    {
        public string Key { get; set; }
        public string Secret { get; set; }
    }
}
