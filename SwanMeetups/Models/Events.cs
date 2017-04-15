using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public int RepID { get; set; }
        public int EventTypeID { get; set; }
        public string EventLocation { get; set; }
        
        [DisplayName("Website URL")]
        public string WebsiteLink { get; set; }

        public virtual Reps Reps { get; set; }
        public virtual EventTypes EventTypes { get; set; }

    }
}