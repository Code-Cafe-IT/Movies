using Movies.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo rạp")]
        [Required(ErrorMessage = "Không được để chống Logo rạp chiếu phim")]
        public string Logo { get; set; }
        [Display(Name = "Tên rạp")]
        [Required(ErrorMessage = "Không được để chống tên rạp")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Không được để chống mô tả rạp")]
        public string Description { get; set; }

        //Quan hệ 
        public List<Movie> Movies { get; set; }
    }
}
