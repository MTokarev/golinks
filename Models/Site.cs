using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace golink.Models
{
    public class Site
    {
        public int Id { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public string Url { get; set; }
        public int Accessed { get; set; }
        public DateTime LastTimeAccessed { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}