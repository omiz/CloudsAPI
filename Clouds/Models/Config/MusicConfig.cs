using System.Data.Entity.ModelConfiguration;

namespace Clouds.Models.Config
{
    public class MusicConfig : EntityTypeConfiguration<Music>
    {
        public MusicConfig()
        {
            HasKey(m => m.Id);

            Property(a => a.Id)
                .IsRequired();

            Property(m => m.Title)
                .HasMaxLength(200);

            Property(m => m.URL)
                .IsRequired();
        }
    }
}