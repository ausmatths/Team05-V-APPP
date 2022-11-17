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
        /// <summary>
        /// The ID for this product, use a Guid so it is always unique, getter, setter
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// getter, setter for maker of Product
        /// </summary>
        public string Maker { get; set; }

        /// <summary>
        /// getter, setter for image of product
        /// </summary>
        [JsonPropertyName("img")]
        public string Image { get; set; }

        /// <summary>
        /// getter, setter for Url of image
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// getter, setter for Title of product
        /// </summary>
        [StringLength (maximumLength: 33, MinimumLength = 1, ErrorMessage = "The Title should have a length of more than {2} and less than {1}")]
        public string Title { get; set; }

        /// <summary>
        /// getter, setter for Description of product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// getter, setter for Ratings of product
        /// </summary>
        public int[] Ratings { get; set; }

        /// <summary>
        /// getter, setter for Type of product
        /// </summary>
        public ProductTypeEnum ProductType { get; set; } = ProductTypeEnum.Undefined;

        /// <summary>
        /// getter, setter for quantity
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// getter, setter for Price of product
        /// </summary>
        [Range (-1, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Price { get; set; }

        /// <summary>
        /// getter, setter for Store the Comments entered by the users on this product
        /// </summary>
        public List<CommentModel> CommentList { get; set; } = new List<CommentModel>();

        /// <summary>
        /// Serializes products
        /// </summary>
        /// <returns></returns>
        public override string ToString() => JsonSerializer.Serialize<ProductModel>(this);
    }
}