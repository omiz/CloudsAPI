using Clouds.Models.Config;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Clouds.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Music> Musics { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AirportConfig());
            modelBuilder.Entity<Airport>();
            modelBuilder.Configurations.Add(new MusicConfig());
            modelBuilder.Entity<Music>();
        }
    }
}