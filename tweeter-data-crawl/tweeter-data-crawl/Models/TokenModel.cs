using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace tweeter_data_crawl.Models
{
    /// <summary>
    /// https://developer.twitter.com/en/docs/basics/authentication/overview/application-only#issuing-application-only-requests
    /// </summary>
    public class TokenModel
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
