﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace DigiGall.Models
{
    public class User
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DateOfBirth { get; set; } = default!;

        public int Galleon { get; set; } = 0;
        public int Rank { get; set; } = 1;

        public User() { 
        }

        public User(string id, string name, string email, string password, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            DateOfBirth = dateOfBirth;
        }
    }
}
