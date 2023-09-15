﻿    using Microsoft.EntityFrameworkCore;
using Museum.Models;
using Museum.Models.Tabs.Info;
using Museum.Models.Tabs.InsideMuseum;
using Museum.Models.Tabs.Media;
using Museum.Models.Tabs.Receiving;
using Museum.Models.Tabs.SpecFund;
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
        public DbSet<Dimentions> Dimentions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Complex> Complexes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Decoding> Decodings { get; set; }
        public DbSet<DetailInfo> DetailInfos { get; set; }
        public DbSet<DetLink> DetLinks{ get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Fund> Funds{ get; set; }
        public DbSet<Gender> Genders{ get; set; }
        public DbSet<Group> Groups{ get; set; }
        public DbSet<Inscript> Inscripts { get; set; }
        public DbSet<KeyWord> KeyWords { get; set; }
        public DbSet<Marking> Markings { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<Stamp> Stamps{ get; set; }
        public DbSet<Tag> Tags{ get; set; }

        public DbSet<Check> Checks { get; set; }
        public DbSet<CheckType> CheckTypes { get; set; }
        public DbSet<Deleting> Deletings{ get; set; }
        public DbSet<Edit> Edits{ get; set; }
        public DbSet<Exhibition> Exhibitions{ get; set; }
        public DbSet<ItemDamage> ItemDamages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MuseumInfo> MuseumInfos { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<StorageCondition> StorageConditions { get; set; }

        public DbSet<Audio> Audios { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageRight> ImageRights { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Media> Medias { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<ReceiveWay> ReceiveWays { get; set; }
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<TimeLimit> TimeLimits { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<DragMetal> DragMetals { get; set; }
        public DbSet<SpecFund> SpecFunds { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Acceptance> Acceptances { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Technique> Techniques { get; set; }
        public DbSet<UnifPassport> UnifPassports { get; set; }

    }
}
