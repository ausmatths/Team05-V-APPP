using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// ContactUs page where all the info of seller is stored
    /// </summary>
    public class ContactUsModel : PageModel
    {
        // Logger for ContactUs
        private readonly ILogger<ContactUsModel> _logger;

        /// <summary>
        /// ContactUsModel Constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="productService"></param>
        public ContactUsModel(ILogger<ContactUsModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /// <summary>
        /// Getter for ProductService
        /// </summary>
        public JsonFileProductService ProductService { get; }

        /// <summary>
        /// Getter setter for products
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