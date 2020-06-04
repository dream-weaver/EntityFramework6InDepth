﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.ExerciseData.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {

            Property(v => v.Name)
            .IsRequired()
            .HasMaxLength(255);

            HasRequired(v => v.Genre)
            .WithMany(t => t.Videos)
            .HasForeignKey(v => v.GenreId)
            .WillCascadeOnDelete(false);

            HasMany(v => v.Tags)
             .WithMany(t => t.Videos)
             .Map(m =>
             {
                 m.ToTable("VideoTags");
                 m.MapLeftKey("VideoId");
                 m.MapRightKey("TagId");
             });
        }
    }
}
