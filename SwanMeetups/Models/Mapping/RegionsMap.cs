using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models.Mapping
{
    public class RegionsMap : EntityTypeConfiguration<Regions>
    {
        public  RegionsMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Set Lengths and Data Types
            this.Property(t => t.Region).HasMaxLength(100);

            //Relationships
            

        }
        
    }
}