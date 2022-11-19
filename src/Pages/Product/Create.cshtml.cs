using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

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

        /// <summary>
        /// Linking to ProductService
        /// </summary>
        /// <param name="productService"></param>
        public CreateModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        [BindProperty]
        public ProductModel Product { get; set; }

        /// <summary>
        /// OnGet gets frist data or default from products
        /// </summary>
        /// <param name="id"></param>
        public void OnGet()
        {
            Product = new ProductModel()
            {
                Id = System.Guid.NewGuid().ToString(),
                Maker = "Enter Maker",
                Title = "Enter Title",
                Description = "Enter Description",
                Price = 0,
                Url = "Enter URL",
                Image = ""
            };
        }

        /// <summary>
        /// Posts the data in product and redirects to product index page
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ProductService.CreateData(Product);

            return RedirectToPage("./Index");
        }
    }
}