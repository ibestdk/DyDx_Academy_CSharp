using System.ComponentModel.DataAnnotations;

namespace DyDx_Academy.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "กรุณากรอก อีเมล ให้ครบถ้วนด้วยครับ")]
        [Display(Name = "Email : ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "กรุณากรอก รหัสผ่าน ด้วยครับ")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
