using System.ComponentModel.DataAnnotations;

namespace EF2.Models
{
    public class Product
    {
        [Key]
        public int pId { get; set; }
        public string? pName { get; set; }
        public string? Manufacture { get; set; }
        public int cId { get; set; }
        
    }
}
