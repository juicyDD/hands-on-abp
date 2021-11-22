using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Models
{
    public class NhanVienRequest
    {
        [Required(ErrorMessage = "Required")]
        [StringLength(255)]
        [Display(Name = "NhanVienName", Prompt = "PlaceHolder")]
        public string Name { get; set; }



        [Required(ErrorMessage = "Requied")]
        [Display(Name = "NhanVienTuoi", Prompt = "PlaceHolder")]
        public int Tuoi { get; set; }
        [Display(Name = "NhanVienCMND", Prompt = "PlaceHolder")]
        public string CMND { get; set; }
        [Required(ErrorMessage = "Requied")]
        public virtual Guid BoPhanId { get; set; }
    }
}
