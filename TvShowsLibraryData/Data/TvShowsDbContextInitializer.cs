using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using TvShowsLibraryData.Models;

namespace TvShowsLibraryData.Data
{
    public class TvShowsDbContextInitializer:DbMigrationsConfiguration<TvShowsDbContext>
    {
        public TvShowsDbContextInitializer()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TvShowsDbContext context)
        {
#if DEBUG
            if (context.TvShows.Count() == 0)
            {
                var tp1 = new TvShow()
                {
                    Title = "Netflix show 1",
                    Description= "A fake tv show for testing",
                    AverageRating= 3
                };
                context.TvShows.Add(tp1);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
#endif


            //#if DEBUG
            //            if (context.Images.Count() == 0)
            //            {
            //                try
            //                {
            //                    _contextLogger.Information("Seed: Seeding db context");
            //                    base.Seed(context);
            //                    var baseDir = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin", string.Empty) + @"\App_Data";
            //                    context.Database.ExecuteSqlCommand(File.ReadAllText(baseDir + @"\ImageTableScript.sql"));
            //                    _contextLogger.Information("Seed: Seeding completed!");
            //                }
            //                catch (Exception ex)
            //                {
            //                    _contextLogger.Error(ex, "Failed to seed database. Error description:{ErrorMessage}", ex.Message);
            //                }
            //            }
            //#endif
        }
    }
}