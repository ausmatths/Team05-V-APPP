using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages.Product
{
    /// <summary>
    /// Read page for products
    /// </summary>
    public class ReadModel : PageModel
    {  
        /// <summary>
        /// Read page will show the product info 
        /// </summary>
        public JsonFileProductService ProductService { get; }
        
        /// <summary>
        /// Read model constructor
        /// </summary>
        /// <param name="productService"></param>
        public ReadModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        // Variable type ProductModel to store first or default data from products
        public ProductModel Product;

        /// <summary>
        /// OnGet function for read
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult OnGet(string id)
        {
            Product = ProductService.GetAllData().FirstOrDefault(m => m.Id.Equals(id));
            if (Product == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}