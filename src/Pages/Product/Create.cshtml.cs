using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace ContosoCrafts.WebSite.Pages.Product
{
    /// Implementing create for creating a new product
    
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        public JsonFileProductService ProductService { get; }

        public ProductModel product { get; private set; }

        // Linking to ProductService
        public CreateModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        // Posts the product and redirects to index page of product
        public IActionResult OnPost(ProductModel product)
        {
            ProductService.CreateData(product);
            return RedirectToPage("./Index");
        }
        public void OnGet()
        {
        }
    }
}
