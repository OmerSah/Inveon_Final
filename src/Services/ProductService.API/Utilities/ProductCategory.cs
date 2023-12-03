using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductService.API.Utilities
{
    public enum ProductCategory
    {
        [Display(Name = "T-shirts")]
        [Description("T-shirts")]
        Tshirts = 1,

        [Display(Name = "Fashion")]
        [Description("Fashion")]
        Fashion = 2,

        [Display(Name = "Çanta")]
        [Description("Çanta")]
        Canta = 3,

        [Display(Name = "Ceket")]
        [Description("Ceket")]
        Ceket = 4,

        [Display(Name = "Ayakkabı")]
        [Description("Ayakkabı")]
        Ayakkabi = 5,

        [Display(Name = "Jeans")]
        [Description("Jeans")]
        Jeans = 6,

    }
  
}

