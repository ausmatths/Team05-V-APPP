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

        public CreateModel(ILogger<CreateModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;

        }

        public void OnGet()
        {
        }
    }
}
