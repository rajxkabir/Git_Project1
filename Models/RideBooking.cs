using System;
using System.ComponentModel.DataAnnotations;

namespace GIT_Practice.Models
{
    public class RideBooking
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string Car { get; set; } = "";

        [Required]
        public DateTime RideDate { get; set; }
    }
}