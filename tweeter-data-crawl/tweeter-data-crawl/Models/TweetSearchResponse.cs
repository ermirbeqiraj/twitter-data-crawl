using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace tweeter_data_crawl.Models
{
    public class TweetSearchResponse
    {
        [JsonProperty("statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Status> Statuses { get; set; }

        [JsonProperty("search_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public SearchMetadata SearchMetadata { get; set; }
    }

    public partial class SearchMetadata
    {
        [JsonProperty("completed_in", NullValueHandling = NullValueHandling.Ignore)]
        public double? CompletedIn { get; set; }

        [JsonProperty("max_id", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxId { get; set; }

        [JsonProperty("max_id_str", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxIdStr { get; set; }

        [JsonProperty("next_results", NullValueHandling = NullValueHandling.Ignore)]
        public string NextResults { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        [JsonProperty("refresh_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshUrl { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("since_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SinceId { get; set; }

        //[JsonProperty("since_id_str", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long? SinceIdStr { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

        [JsonProperty("id_str", NullValueHandling = NullValueHandling.Ignore)]
        public string IdStr { get; set; }

        [JsonProperty("full_text", NullValueHandling = NullValueHandling.Ignore)]
        public string FullText { get; set; }

        [JsonProperty("truncated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Truncated { get; set; }

        [JsonProperty("display_text_range", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> DisplayTextRange { get; set; }

        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEntities Entities { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("in_reply_to_status_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InReplyToStatusId { get; set; }

        [JsonProperty("in_reply_to_status_id_str", NullValueHandling = NullValueHandling.Ignore)]
        public string InReplyToStatusIdStr { get; set; }

        [JsonProperty("in_reply_to_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InReplyToUserId { get; set; }

        //[JsonProperty("in_reply_to_user_id_str", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        //public long? InReplyToUserIdStr { get; set; }

        [JsonProperty("in_reply_to_screen_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InReplyToScreenName { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        //[JsonProperty("geo")]
        //public object Geo { get; set; }

        //[JsonProperty("coordinates")]
        //public object Coordinates { get; set; }

        //[JsonProperty("place")]
        //public object Place { get; set; }

        //[JsonProperty("contributors")]
        //public object Contributors { get; set; }

        [JsonProperty("is_quote_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQuoteStatus { get; set; }

        [JsonProperty("retweet_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RetweetCount { get; set; }

        [JsonProperty("favorite_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FavoriteCount { get; set; }

        [JsonProperty("favorited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Favorited { get; set; }

        [JsonProperty("retweeted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retweeted { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }
    }

    public partial class StatusEntities
    {
        [JsonProperty("hashtags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Hashtags { get; set; }

        [JsonProperty("symbols", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Symbols { get; set; }

        [JsonProperty("user_mentions", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserMention> UserMentions { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Urls { get; set; }
    }

    public partial class UserMention
    {
        [JsonProperty("screen_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenName { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("id_str", NullValueHandling = NullValueHandling.Ignore)]
        public string IdStr { get; set; }

        [JsonProperty("indices", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Indices { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("iso_language_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IsoLanguageCode { get; set; }

        [JsonProperty("result_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultType { get; set; }
    }

    public partial class User
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("id_str", NullValueHandling = NullValueHandling.Ignore)]
        public string IdStr { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("screen_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenName { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntities Entities { get; set; }

        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        [JsonProperty("followers_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FollowersCount { get; set; }

        [JsonProperty("friends_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FriendsCount { get; set; }

        [JsonProperty("listed_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ListedCount { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("favourites_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FavouritesCount { get; set; }

        [JsonProperty("utc_offset")]
        public object UtcOffset { get; set; }

        [JsonProperty("time_zone")]
        public object TimeZone { get; set; }

        [JsonProperty("geo_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GeoEnabled { get; set; }

        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        [JsonProperty("statuses_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? StatusesCount { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }

        [JsonProperty("contributors_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContributorsEnabled { get; set; }

        [JsonProperty("is_translator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTranslator { get; set; }

        [JsonProperty("is_translation_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTranslationEnabled { get; set; }

        [JsonProperty("profile_background_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileBackgroundColor { get; set; }

        [JsonProperty("profile_background_image_url")]
        public Uri ProfileBackgroundImageUrl { get; set; }

        [JsonProperty("profile_background_image_url_https")]
        public Uri ProfileBackgroundImageUrlHttps { get; set; }

        [JsonProperty("profile_background_tile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProfileBackgroundTile { get; set; }

        [JsonProperty("profile_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ProfileImageUrl { get; set; }

        [JsonProperty("profile_image_url_https", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ProfileImageUrlHttps { get; set; }

        [JsonProperty("profile_link_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileLinkColor { get; set; }

        [JsonProperty("profile_sidebar_border_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileSidebarBorderColor { get; set; }

        [JsonProperty("profile_sidebar_fill_color", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileSidebarFillColor { get; set; }

        [JsonProperty("profile_text_color", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string ProfileTextColor { get; set; }

        [JsonProperty("profile_use_background_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProfileUseBackgroundImage { get; set; }

        [JsonProperty("has_extended_profile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasExtendedProfile { get; set; }

        [JsonProperty("default_profile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultProfile { get; set; }

        [JsonProperty("default_profile_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultProfileImage { get; set; }

        [JsonProperty("following")]
        public object Following { get; set; }

        [JsonProperty("follow_request_sent")]
        public object FollowRequestSent { get; set; }

        [JsonProperty("notifications")]
        public object Notifications { get; set; }

        [JsonProperty("translator_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TranslatorType { get; set; }

        [JsonProperty("profile_banner_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ProfileBannerUrl { get; set; }
    }

    public partial class UserEntities
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public Description Description { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Urls { get; set; }
    }
}
