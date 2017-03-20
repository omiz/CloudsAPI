using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Clouds.Models.Config;

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
            modelBuilder.Configurations.Add(new AirportConfig());
            modelBuilder.Configurations.Add(new MusicConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}