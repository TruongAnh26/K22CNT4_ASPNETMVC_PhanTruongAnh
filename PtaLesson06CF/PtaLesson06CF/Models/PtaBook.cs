using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PtaLesson06CF.Models
{
    public class PtaBook
    {
        [Key]
        public int PtaId { get; set; }
        public string PtaBookId { get; set; }
        public string PtaTitle {  get; set; }
        public string PtaAuthor { get; set; }
        public string PtaYear { get; set; }
        public string PtaPublisher { get; set; }
        public int PtaCategoryID { get; set; }
        public virtual PtaCategories PtaCategories {  get; set; } 
    }
}