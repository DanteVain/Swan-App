using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SwanMeetups.Models
{
    public class Reps
    {
        [Key]
        public int RepID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string RegionID { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Events> Events { get; set; }

        public virtual Regions Regions { get; set; }
    }
}
