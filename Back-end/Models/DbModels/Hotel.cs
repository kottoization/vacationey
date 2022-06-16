﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models.DbModels
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Range(1, 5, ErrorMessage = "Value out of range")] 
        public int Rate { get; set; }

        public int CityId { get; set; }

        [Required]
        [ForeignKey("CityId")]
        public virtual City? City { get; set; }

        public bool Pool { get; set; }
        public bool WiFi { get; set; }

        public Hotel(){}

        public Hotel(string? name, int rate, City? city, bool pool, bool wiFi)
        {
            Name = name;
            Rate = rate;
            City = city;
            Pool = pool;
            WiFi = wiFi;
        }

    }
}
