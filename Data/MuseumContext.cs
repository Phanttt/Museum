    using Microsoft.EntityFrameworkCore;
using Museum.Models;
using Museum.Models.Tabs.Info;
using Museum.Models.Tabs.InsideMuseum;
using Museum.Models.Tabs.Media;
using Museum.Models.Tabs.Receiving;
using Museum.Models.Users;

namespace Museum.Data
{
    public class MuseumContext : DbContext
    {
        public MuseumContext()
        {
        }

        public MuseumContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<DetailInfo> DetailInfos { get; set; }
        public DbSet<Fund> Funds{ get; set; }
        public DbSet<Group> Groups{ get; set; }
        public DbSet<KeyWord> KeyWords { get; set; }
        public DbSet<Tag> Tags{ get; set; }

        public DbSet<Edit> Edits{ get; set; }
        public DbSet<Exhibition> Exhibitions{ get; set; }
        public DbSet<InsideInfo> InsideInfos { get; set; }
        public DbSet<DataFile> DataFiles { get; set; }

        public DbSet<Audio> Audios { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageRight> ImageRights { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Media> Medias { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<ReceiveWay> ReceiveWays { get; set; }
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Acceptance> Acceptances { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Technique> Techniques { get; set; }
        public DbSet<UnifPassport> UnifPassports { get; set; }

        public DbSet<GeneralInfo> GeneralInfo { get; set; }

        public DbSet<News> News { get; set; }
    }
}
