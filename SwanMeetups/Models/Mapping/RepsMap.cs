using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models.Mapping
{
    public class RepsMap : EntityTypeConfiguration<Reps>
    {
        public RepsMap()
        {
            // Primary Key
            this.HasKey(t => t.RepID);

            // Set Lengths and Data Types

            //Relationships
            this.HasRequired(t => t.Regions)
                .WithMany(t => t.Reps)
                .HasForeignKey(t => t.RegionID);
        }

    }
}