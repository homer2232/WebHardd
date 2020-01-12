using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebHard.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "{0} обязательно для заполнения.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} обязательно для заполнения.")]
        [Display(Name = "Год рождения")]
        public int Year { get; set; }

        [Required(ErrorMessage = "{0} обязательно для заполнения.")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} обязательно для заполнения.")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
