using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SalesWebApi.Models {
    public class OrderLine {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Product { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        [JsonIgnore]                             //prevents cyclical repeater in JSON program (postman in this case)
        public virtual Order Order { get; set; } //refer to OrderController .Include(x=>x.OrderLines)

        public OrderLine() { }
    }
}
