using SwanMeetups.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SwanMeetups.DAL
{
    public class EventDBContext : DbContext
    {
        public EventDBContext() : base("EventContext")
        {
        }

        public DbSet<Reps> Reps { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventTypes> EventTypes { get; set; }
        public DbSet<Regions> Regions { get; set; }

    }
}