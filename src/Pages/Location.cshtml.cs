using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages
{
    public class LocationModel : PageModel
    {
        private readonly ILogger<LocationModel> _logger;

        public LocationModel(ILogger<LocationModel> mockLoggerDirect)
        {
        }

        public LocationModel(ILogger<LocationModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        public IEnumerable<ProductModel> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetAllData();
        }
    }
}
