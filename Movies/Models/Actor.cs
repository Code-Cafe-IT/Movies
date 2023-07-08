using Movies.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Hình Ảnh")]
        [Required(ErrorMessage ="Vui lòng nhập vào hình ảnh")]
        public string ProfilePictureURL { get; set; }        
        [Display(Name = "Tên Đầy Đủ")]
        [Required(ErrorMessage = "Vui lòng nhập vào họ và tên")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Họ và tên có độ dài từ 3 đến 50 kí tự")]
        public string FullName { get; set; }
        [Display(Name = "Tiểu Sử")]
        [Required(ErrorMessage = "Vui lòng nhập vào tiêu sử")]
        public string Bio { get; set; }
        //Quan hệ
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
