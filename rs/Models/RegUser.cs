﻿using System.ComponentModel.DataAnnotations;

    public class RegUser
    {

        [Key]
       public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
