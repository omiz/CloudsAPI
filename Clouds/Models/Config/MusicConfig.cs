using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Clouds.Models.Config
{
    public class MusicConfig : EntityTypeConfiguration<Music>
    {
        public MusicConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Title)
                .HasMaxLength(200);

            Property(a => a.URL)
                .IsRequired();
        }
    }
}