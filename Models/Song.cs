using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab7.Models
{
    public class Song {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(100, ErrorMessage = "Maximal length of thename of a song is 100 characters!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Artist is required!")]
        [StringLength(100, ErrorMessage = "Maximal length of artist name is 100 characters!")]
        public string Artist { get; set; }
        public int GenreId { get; set; }


        public Song()
        {
            this.Name = "empty";
            this.Artist = "empty";
            this.GenreId = 0;
            this.Id = 0;
        }
        public Song(string name, string artist, int genreId, int id)
        {
            this.Name = name;
            this.Artist = artist;
            this.GenreId = genreId;
            this.Id = id;
        }
    }
}