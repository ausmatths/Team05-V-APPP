using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ContosoCrafts.WebSite.Models
{
    /// <summary>
    /// Products entered by the admin about the Product
    /// </summary>
    public class ProductModel
    {
        // The ID for this product, use a Guid so it is always unique
        public string Id { get; set; }

        // Maker of Product
        public string Maker { get; set; }

        // Image of product
        [JsonPropertyName("img")]
        public string Image { get; set; }

        // Url of image
        public string Url { get; set; }
        
        // Title of product
        [StringLength (maximumLength: 33, MinimumLength = 1, ErrorMessage = "The Title should have a length of more than {2} and less than {1}")]
        public string Title { get; set; }

        // Description of product
        public string Description { get; set; }

        // Ratings of product
        public int[] Ratings { get; set; }

        // Type of product
        public ProductTypeEnum ProductType { get; set; } = ProductTypeEnum.Undefined;

        // Quantity of product
        public string Quantity { get; set; }

        // Price of product
        [Range (-1, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Price { get; set; }

        // Store the Comments entered by the users on this product
        public List<CommentModel> CommentList { get; set; } = new List<CommentModel>();

        public override string ToString() => JsonSerializer.Serialize<ProductModel>(this);


    }
}