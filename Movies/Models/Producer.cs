using Movies.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Movies.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Hình ảnh")]
        [Required(ErrorMessage = "Hình ảnh bắt buộc phải nhập")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Tên đầy đủ")]
        [Required(ErrorMessage = "Tên đầy đủ bắt buộc phải nhập")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên đầy đủ phải đủ từ 3 đến 50 kí tự")]
        public string FullName { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả bắt buộc phải nhập")]
        public string Bio { get; set; }

        //Quan hệ 
        public List<Movie> Movies { get; set; }
    }
}
