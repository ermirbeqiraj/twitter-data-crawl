using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using tweeter_data_crawl.Models;
using tweeter_data_crawl.Services;

namespace tweeter_data_crawl
{
    class Program
    {
        static AppSettings SETTINGS;
        static readonly string CONFIG_FILE_PATH = Path.Combine(Environment.CurrentDirectory, "Data", "appsettings.json");

        static void ReadAppSettings()
        {
            if (File.Exists(CONFIG_FILE_PATH))
            {
                var settingsString = File.ReadAllText(CONFIG_FILE_PATH);
                SETTINGS = JsonConvert.DeserializeObject<AppSettings>(settingsString);
            }
            else
            {
                throw new Exception("Application settings file couldn't be found");
            }
        }

        static async Task Main(string[] args)
        {
            ReadAppSettings();

            var searchService = new SearchService(SETTINGS.AuthorizeToken);
            var data = await searchService.GetData("?q=to:ediramaal&sinceId=1097126568537792512&until=2019-02-18&tweet_mode=extended&count=3");

            var dataObj = JsonConvert.DeserializeObject<TweetSearchResponse>(data);

            Console.ReadLine();
        }
    }
}
