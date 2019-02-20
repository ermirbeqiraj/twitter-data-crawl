using System;
using System.Collections.Generic;

namespace tweeter_data_crawl.Entities
{
    public partial class Tweet
    {
        public Tweet()
        {
            InverseInReplyToStatus = new HashSet<Tweet>();
        }

        public long Id { get; set; }
        public string CreatedAt { get; set; }
        public string FullText { get; set; }
        public long? RetweetCount { get; set; }
        public long? FavoriteCount { get; set; }
        public long? InReplyToStatusId { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string UserScreenName { get; set; }
        public string UserLocation { get; set; }
        public long? UserFollowersCount { get; set; }
        public long? UserFriendsCount { get; set; }
        public string UserCreatedAt { get; set; }
        public long? UserFavouritesCount { get; set; }
        public long? UserStatusesCount { get; set; }
        public string TweetText { get; set; }

        public virtual Tweet InReplyToStatus { get; set; }
        public virtual ICollection<Tweet> InverseInReplyToStatus { get; set; }
    }
}
