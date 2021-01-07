using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_book_store.Models
{
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Qty { get; set; }
        public int Cost { get; set; }
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int BookID { get; set; }
        [Required]
        public int ID { get; set; }
        [Required]
        public int BookTypeID { get; set; }
        [Required]
    }
}
