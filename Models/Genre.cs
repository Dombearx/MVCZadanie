using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class Genre {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(100, ErrorMessage = "Maximal length of genre name is 100 characters!")]
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }

        public Genre()
        {
            this.Name = "empty";
            this.Songs = new List<Song>(); 
            this.Id = 0;
        }

        public Genre(int id, string name, ICollection<Song> songs)
        {
            Id = id;
            Name = name;
            Songs = songs;
        }
    }
}