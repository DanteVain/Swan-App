using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwanMeetups.Models
{
    public class Regions
    {
        [Key]
        public int RegionID { get; set; }
        public string Region { get; set; }

        public virtual ICollection<Reps> Reps { get; set; }
    }
}