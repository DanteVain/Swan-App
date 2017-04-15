using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models.Mapping
{
    public class EventsMap : EntityTypeConfiguration<Events>
    {
        public EventsMap()
        {
            // Primary Key
            this.HasKey(t => t.EventID);

            // Set Lengths and Data Types
            this.Property(t => t.EventLocation).HasMaxLength(100);

            //Relationships
            
            this.HasRequired(t => t.EventTypes)
                .WithMany(t => t.Events)
                .HasForeignKey(t => t.EventTypeID);

            this.HasRequired(t => t.Reps)
                .WithMany(t => t.Events)
                .HasForeignKey(t => t.RepID);

        }

    }
}