using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PtaLesson06CF.Models
{
    public class PtaBookStore:DbContext
    {
        public PtaBookStore():base("PtaBookStoreConnectionString") 
        {
            
        }
        public DbSet<PtaCategories> PtaCategories { get; set; }
        public DbSet<PtaBook> PtaBooks { get; set; }
    }
}