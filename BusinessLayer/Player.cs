using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Player //za dovurshvane
    {
        private Player()
        {
            
        }

        public Player(int id,string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
