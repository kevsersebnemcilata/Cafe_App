using System.ComponentModel.DataAnnotations;

namespace CafeApp.Models
{
    public class Galeri
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
    }
}
