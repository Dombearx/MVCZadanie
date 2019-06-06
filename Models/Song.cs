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
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }


        public Song()
        {
            this.Name = "empty";
            this.Artist = "empty";
            this.Genre = "empty";
            this.Id = 0;
        }
        public Song(string name, string artist, string genre, int id)
        {
            this.Name = name;
            this.Artist = artist;
            this.Genre = genre;
            this.Id = id;
        }
    }
}