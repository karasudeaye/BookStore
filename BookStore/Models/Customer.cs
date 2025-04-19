using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; } 
    }
}
