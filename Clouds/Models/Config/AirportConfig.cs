using System.Data.Entity.ModelConfiguration;

namespace Clouds.Models
{
    public class AirportConfig : EntityTypeConfiguration<Airport>
    {
        public AirportConfig()
        {
            HasKey(a => a.Id);

            Property(a => a.Id)
                .IsRequired();

            Property(a => a.Country)
                .HasMaxLength(100);

            Property(a => a.State)
                .HasMaxLength(100);

            Property(a => a.City)
                .HasMaxLength(100);

            Property(a => a.Code)
                .IsRequired();

            Property(m => m.URL)
                .IsRequired();
        }
    }
}