using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_book_store.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int OrderStatysID { get; set; }
        [Required]
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Address { get; set; }
        public int Cost { get; set; }
        public int DateOfOrder { get; set; }
        public int DateOfDeliver { get; set; }
    }
}
