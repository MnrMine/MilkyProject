﻿using System.ComponentModel.DataAnnotations;

namespace MilkyProject.WebUI.Dtos.Login
{
    public class CreateLogin
    {
        [Required(ErrorMessage = "Mail Adresinizi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz!")]
        public string Password { get; set; }
    }
}
