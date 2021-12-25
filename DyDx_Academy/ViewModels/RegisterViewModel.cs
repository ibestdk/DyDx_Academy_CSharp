using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DyDx_Academy.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "กรุณากรอก UserName ให้ครบถ้วนด้วยครับ")]
        [Display(Name = "UserName : ")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="กรุณากรอก อีเมล ให้ครบถ้วนด้วยครับ")]
        [Display(Name ="Email : ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "กรุณากรอก รหัสผ่าน ด้วยครับ")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "กรุณากรอก รหัสผ่าน อีกครั้งด้วยครับ")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="รหัสผ่านไม่ตรงกัน")]
        public string ConfirmPassword { get; set; }
    }
}
