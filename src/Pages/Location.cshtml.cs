using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Location page shows location of the seller
    /// </summary>
    public class LocationModel : PageModel
    {
        // Logger variable
        private readonly ILogger<LocationModel> _logger;

        /// <summary>
        /// Location model mockLogger
        /// </summary>
        /// <param name="mockLoggerDirect"></param>
        public LocationModel(ILogger<LocationModel> mockLoggerDirect)
        {
        }

        /// <summary>
        /// Constructor LocationModel logger cariable instantiation
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="productService"></param>
        public LocationModel(ILogger<LocationModel> logger,
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
        /// Getter setter for Products
        /// </summary>
        public IEnumerable<ProductModel> Products { get; private set; }

        /// <summary>
        /// Gets all the data
        /// </summary>
        public void OnGet()
        {
            Products = ProductService.GetAllData();
        }
    }
}