using System;
using System.Collections.Generic;
using System.Text;

namespace tweeter_data_crawl.Services
{
    /// <summary>
    /// https://developer.twitter.com/en/docs/basics/authentication/overview/application-only#issuing-application-only-requests
    /// 1. URL encode the consumer key and the consumer secret according to RFC 1738. Note that at the time of writing, this will not actually change the consumer key and secret, 
    /// but this step should still be performed in case the format of those values changes in the future.
    /// 2. Concatenate the encoded consumer key, a colon character ”:”, and the encoded consumer secret into a single string.
    /// 3. Base64 encode the string from the previous step.
    /// </summary>
    public class Authenticate
    {
        public Authenticate()
        {

        }
        

        /// <summary>
        /// Get token from twitter api
        /// </summary>
        public void GetToken()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// persist token to appconfig
        /// </summary>
        private void SaveToken()
        {
            throw new NotImplementedException();
        }
    }
}
