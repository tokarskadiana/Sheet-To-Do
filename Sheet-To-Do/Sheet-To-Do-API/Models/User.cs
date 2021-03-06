﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Sheet_To_Do_API.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "User name is required.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }

    public class UserView
    {
        public int UserId { get; set; }
        public string Login { get; set; }

        public UserView(int userId, string login)
        {
            UserId = userId;
            Login = login;
        }
    }
}