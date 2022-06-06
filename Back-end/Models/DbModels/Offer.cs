﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models.DbModels
{
    public class Offer
    {
        public Offer(string? name, Hotel? hotel, decimal price, DateTime dateFrom, DateTime dateTo, City? 
            departureCity, City? arrivalCity, bool fullBoard, int numberOfPeople)
        {
            Name = name;
            Hotel = hotel;
            Price = price;
            DateFrom = dateFrom;
            DateTo = dateTo;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            FullBoard = fullBoard;
            NumberOfPeople = numberOfPeople;
            //Admin = admin;
        }
        public Offer() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OfferId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        public Hotel? Hotel { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateFrom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTo { get; set; }

        public City? DepartureCity { get; set; }

        public City? ArrivalCity { get; set; }

        public bool FullBoard { get; set; }

  

        //default 1
        public int NumberOfPeople { get; set; }

        [Column("CreatedBy")]
        public Admin? Admin { get; set; }
    }
}