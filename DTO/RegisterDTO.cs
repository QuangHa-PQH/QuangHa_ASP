﻿namespace Phamquangha_2122110195_1.DTO
{
    public class RegisterDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; } 

        public string Address { get; set; }
        public string Role { get; set; } = "ROLE_USER"; 

    }
}
