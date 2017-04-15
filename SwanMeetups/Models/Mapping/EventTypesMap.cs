using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models.Mapping
{
    public class EventTypesMap : EntityTypeConfiguration<EventTypes>
    {
        public EventTypesMap()
        {
            // Primary Key
            this.HasKey(t => t.EventTypeID);

            // Set Lengths and Data Types
            this.Property(t => t.EventType).HasMaxLength(100);

            //Relationships
            

        }

    }
}