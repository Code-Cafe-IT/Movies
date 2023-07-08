using Movies.Data;
using Movies.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Tên phim")]
        [Required(ErrorMessage = "Bắt buộc nhập vào tên bộ phim")]
        public string Name { get; set; }

        [Display(Name = "Mô tả bộ phim")]
        [Required(ErrorMessage = "Bắt buộc nhập vào trường mô tả")]
        public string Description { get; set; }

        [Display(Name = "Giá của phim $")]
        [Required(ErrorMessage = "Bắt buộc nhập vào giá")]
        public double Price { get; set; }

        [Display(Name = "Địa chỉ URL hình ảnh")]
        [Required(ErrorMessage = "Bắt buộc nhập vào hình ảnh")]
        public string ImageURL { get; set; }

        [Display(Name = "Ngày bắt đầu bộ phim")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày kết thúc bộ phim")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Chọn thể loại")]
        [Required(ErrorMessage = "Vui lòng nhập thể loại phim")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Chọn diễn viên(s)")]
        [Required(ErrorMessage = "Diễn viên(s) là bắt buộc")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Chọn rạp phim")]
        [Required(ErrorMessage = "Diễn viên là bắt buộc nhập")]
        public int CinemaId { get; set; }

        [Display(Name = "Chọn nhà sản xuất")]
        [Required(ErrorMessage = "Chọn nhà sản xuất phim là bắt buộc nhập")]
        public int ProducerId { get; set; }
    }
}