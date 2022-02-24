using System.ComponentModel.DataAnnotations;

namespace EF2.Models
{
    public class Category
    {
        [Key]
        public int cId { get; set; }
        public string? cName { get; set; }
        
    }
}