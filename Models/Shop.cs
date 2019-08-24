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
        public string Type { get; set; }
        public string Name { get; set; }
        public int PRange { get; set; }
    }
}
