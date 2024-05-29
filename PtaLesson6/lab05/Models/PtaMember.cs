using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab05.Models
{
    public class PtaMember
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Hay nhap ten dang nhap")]
        public string PtaUserName { get; set; }
        [Required(ErrorMessage ="Hay nhap mat khau")]
        [DataType (DataType.Password)]
        public string PtaPassword { get; set;}
        [Required(ErrorMessage ="Hay nhap tuoi")]
        [Range(18,50,ErrorMessage ="Tuoi tu 18-50")]
        public int PtaAge { get; set;}
        
    }
}