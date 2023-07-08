using System.ComponentModel.DataAnnotations;

namespace Movies.Data.ViewModels
{
    public class LoginVM
    {

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Địa chỉ Email bắt buộc phải nhập")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
