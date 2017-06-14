using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TvShowsLibraryData.Models;

namespace TvShowsLibraryData.Data
{
    public class TvShowsDbContext: DbContext
    {
        public TvShowsDbContext():base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TvShowsDbContext, TvShowsDbContextInitializer>());
        }

        public DbSet<TvShow> TvShows { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PriceType> PriceType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<EpisodePriceType> EpisodePriceType { get; set; }
        public DbSet<PersonSkill> PersonSkill { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductionHouse> ProductionHouse { get; set; }
        public DbSet<TvShowProductionHouse> TvShowProductionHouse { get; set; }
        public DbSet<TvShowGenre> TvShowGenre { get; set; }
        public DbSet<TvShowPersonSkill> TvShowPersonSkill { get; set; }
        public DbSet<TvShowRating> TvShowRating { get; set; }
    }
}