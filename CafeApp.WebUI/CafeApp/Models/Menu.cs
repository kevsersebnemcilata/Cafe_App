using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]  
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Ozel { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


    }
}
