using Microsoft.EntityFrameworkCore;

namespace tweeter_data_crawl.Entities
{
    public partial class TweeterContext : DbContext
    {
        public TweeterContext()
        {
        }

        public TweeterContext(DbContextOptions<TweeterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tweet> Tweet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=twitter-search;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Tweet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasMaxLength(100);

                entity.Property(e => e.FavoriteCount).HasColumnName("favorite_count");

                entity.Property(e => e.FullText)
                    .HasColumnName("full_text")
                    .HasMaxLength(280);

                entity.Property(e => e.InReplyToStatusId).HasColumnName("in_reply_to_status_id");

                entity.Property(e => e.RetweetCount).HasColumnName("retweet_count");

                entity.Property(e => e.TweetText).HasColumnName("tweet_text");

                entity.Property(e => e.UserCreatedAt)
                    .HasColumnName("user_created_at")
                    .HasMaxLength(100);

                entity.Property(e => e.UserFavouritesCount).HasColumnName("user_favourites_count");

                entity.Property(e => e.UserFollowersCount).HasColumnName("user_followers_count");

                entity.Property(e => e.UserFriendsCount).HasColumnName("user_friends_count");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserLocation)
                    .HasColumnName("user_location")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserScreenName)
                    .HasColumnName("user_screen_name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserStatusesCount).HasColumnName("user_statuses_count");

                entity.HasOne(d => d.InReplyToStatus)
                    .WithMany(p => p.InverseInReplyToStatus)
                    .HasForeignKey(d => d.InReplyToStatusId)
                    .HasConstraintName("FK_Tweet_Tweet");
            });
        }
    }
}
