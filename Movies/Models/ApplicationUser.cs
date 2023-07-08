using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Tên đầy đủ")]
        public string FullName { get; set; }
    }
}
