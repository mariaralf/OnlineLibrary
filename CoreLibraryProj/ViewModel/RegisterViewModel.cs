using System.ComponentModel.DataAnnotations;

namespace CoreLibraryProj.ViewModel
{
    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Рік народження")]
        public int Year { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        [Display(Name ="Password confirmation")]
        [DataType(DataType.Password)]

        public string PasswordConfirm { get; set; }

    }
}
