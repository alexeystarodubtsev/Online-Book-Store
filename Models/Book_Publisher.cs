﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_book_store.Models
{
    public class Book_Publisher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int BookID { get; set; }
        [Required]
        public int PublisherID { get; set; }
    }
}
