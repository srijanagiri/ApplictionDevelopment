﻿using System.ComponentModel.DataAnnotations;
namespace CW2AD.Models
{
    public class Actor
    {
        [Key]
        public int ActorNumber { get; set; }
        public string ActorSurname { get; set; }
        public string ActorFirstName { get; set; }
    }
}
