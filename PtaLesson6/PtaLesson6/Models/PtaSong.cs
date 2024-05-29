using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PtaLesson6.Models
{
    public class PtaSong
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage = "Pta: Hãy nhập tiêu đề")]
        public string PtaTitle { get; set; }
        [Required(ErrorMessage = "Pta: Hãy nhập tác giả")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pta: tên tối thiểu 2 ký tự và ít hơn 50 ký tự")]
        public string PtaAuthor { get; set; }
        [Required]
        public string PtaArtist { get; set; }
        [Required(ErrorMessage = "hãy nhập năm")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Hãy nhập 4 ký tự từ số")]
        [Range(1900,2024,ErrorMessage ="Pta: năm xuất bản trong khoảng 1900-2024")]
        public int PtaYearRelease { get; set; }
    }
}