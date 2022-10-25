using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        public JsonFileProductService ProductService { get; }

        public ProductModel product { get; private set; }

        public CreateModel(ILogger<CreateModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;

        }

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
