using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApi.Models
{
    [Table("shops")]
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public int PRange { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
