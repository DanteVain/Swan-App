using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models
{
    public class EventTypes
    {
        [Key]
        public int EventTypeID { get; set;}
        public string EventType { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}