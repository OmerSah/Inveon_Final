﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FavoriteService.API.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
