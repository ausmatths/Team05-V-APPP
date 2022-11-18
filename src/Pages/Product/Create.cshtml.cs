using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoCrafts.WebSite.Pages.Product
{
    /// <summary>
    /// Implementing create for creating a new product
    /// </summary>
    public class CreateModel : PageModel
    {
        /// <summary>
        /// Getter for ProductService 
        /// </summary>
        public JsonFileProductService ProductService { get; }

        /// <summary>
        /// getter setter for product
        /// </summary>
        public ProductModel product { get; private set; }

        /// <summary>
        /// Linking to ProductService
        /// </summary>
        /// <param name="productService"></param>
        public CreateModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        /// <summary>
        /// Posts the product and redirects to index page of product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public IActionResult OnPost(ProductModel product)
        {
            ProductService.CreateData(product);
            return RedirectToPage("./Index");
        }
    }
}