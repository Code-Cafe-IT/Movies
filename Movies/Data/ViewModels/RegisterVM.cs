using System.ComponentModel.DataAnnotations;

namespace Movies.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Tên đầy đủ")]
        [Required(ErrorMessage = "Bắt buộc phải nhập vào tên đầy đủ")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Địa chỉ Email bắt buộc phải nhập")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Xác nhận lại mật khẩu")]
        [Required(ErrorMessage = "Bắt buộc phải xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không phù hợp")]
        public string ConfirmPassword { get; set; }
    }
}
