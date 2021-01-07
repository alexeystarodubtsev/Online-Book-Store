using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_book_store.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriseAudio { get; set; }
        public int PriseElectronic { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int AutorID { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int PublisherID { get; set; }
        [Required]
        public int ID { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]

    }
}
