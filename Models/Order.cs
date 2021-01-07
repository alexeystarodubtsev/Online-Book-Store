using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_book_store.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int OrderStatusID { get; set; }
        [Required]
        public string CustomerFirstName { get; set; }
        [Required]
        public string CustomerLastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public int DateOfOrder { get; set; }
        [Required]
        public int DateOfDeliver { get; set; }
    }
}
