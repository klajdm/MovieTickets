﻿using MovieTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Decription")]
        public string? Description { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
