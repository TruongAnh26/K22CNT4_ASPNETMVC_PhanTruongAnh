using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PtaLesson06CF.Models
{
    public class PtaCategories
    {
        [Key]
        public int PtaId { get; set; }
        public string PtaCategoryName { get; set; }
        public virtual ICollection<PtaBook> PtaBooks { get; set; }

    }
}