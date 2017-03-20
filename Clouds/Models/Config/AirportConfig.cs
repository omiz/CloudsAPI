using System.Data.Entity.ModelConfiguration;

namespace Clouds.Models
{
    public class AirportConfig : EntityTypeConfiguration<Airport>
    {
        public AirportConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Country)
                .HasMaxLength(100);

            Property(c => c.State)
                .HasMaxLength(100);

            Property(c => c.City)
                .HasMaxLength(100);

            Property(a => a.Code)
                .IsRequired();
        }
    }
}