using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace GräsÄnklingar.Models
{
    public class And
    {
        Kon konet = new Kon();
        public virtual int andid { get; set; }
        [Required]
        [Display(Name = "Förnamn")]
        public virtual string andNamn { get; set; }
        [Required]
        public virtual string intressen { get; set; }
    }
}