using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Displays products
    /// </summary>
    public class ProductDisplayModel : PageModel
    {
        // Varibale for logger
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Constructor for ProductDisplayModel
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="productService"></param>
        public ProductDisplayModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /// <summary>
        /// Getter for JsonFileProductService ProductService 
        /// </summary>
        public JsonFileProductService ProductService { get; }

        /// <summary>
        /// Getter setter for products
        /// </summary>
        public IEnumerable<ProductModel> Products { get; private set; }

        /// <summary>
        /// OnGet to get all data
        /// </summary>
        public void OnGet()
        {
            Products = ProductService.GetAllData();
        }
    }
}