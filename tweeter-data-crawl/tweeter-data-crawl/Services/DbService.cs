using System.Collections.Generic;
using System.Linq;
using tweeter_data_crawl.Entities;

namespace tweeter_data_crawl.Services
{
    public class DbService
    {
        public DbService() { }

        public void AddTweets(List<Tweet> items)
        {
            var ids = items.Select(x => x.Id).ToList();
            using (var _context = new TweeterContext())
            {
                var existsingIds = _context.Tweet.Where(x => ids.Contains(x.Id)).Select(x => x.Id).ToList();
                items = items.Where(x => !existsingIds.Contains(x.Id)).ToList();
                if (items.Count > 0)
                {
                    _context.Tweet.AddRange(items);
                    _context.SaveChanges();
                }
            }
        }

        public long[] GetTweetIds(long userId)
        {
            using (var _context = new TweeterContext())
            {
                return _context.Tweet.Where(x => x.UserId == userId).Select(x => x.Id).ToArray();
            }
        }

        public long? GetLastSavedTweetId(long userId)
        {
            using (var _context = new TweeterContext())
            {
                return _context.Tweet.Where(x => x.UserId == userId).Max(x => (long?)x.Id);
            }
        }
    }
}
