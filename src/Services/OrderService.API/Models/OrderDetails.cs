﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OrderService.API.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }
        public int OrderHeaderId { get; set; }
        [ForeignKey("OrderHeaderId")]
        [JsonIgnore]
        public virtual OrderHeader OrderHeader { get; set; }
        public int ProductId { get; set; }

        public int Count { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
