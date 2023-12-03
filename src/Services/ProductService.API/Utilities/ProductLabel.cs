using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductService.API.Utilities
{
    public enum ProductLabel
    {
        [Display(Name = "Trending")]
        [Description("Trending")]
        Trending = 1,

        [Display(Name = "45% OFF")]
        [Description("45% OFF")]
        Discount45Percent = 2,

        [Display(Name = "50% OFF")]
        [Description("50% OFF")]
        Discount50Percent = 3,

        [Display(Name = "Hot")]
        [Description("Hot")]
        Hot = 4,

        [Display(Name = "Upcoming")]
        [Description("Upcoming")]
        Upcoming = 5,

        [Display(Name = "Popular")]
        [Description("Popular")]
        Popular = 6,

        [Display(Name = "Top Choice")]
        [Description("Top Choice")]
        TopChoice = 7,

        [Display(Name = "Best Selling")]
        [Description("Best Selling")]
        BestSelling = 8
    }
}
