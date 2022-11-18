using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages.Product
{
    /// <summary>
    ///  Update Page will let the user update the existing data
    /// </summary>
    public class UpdateModel : PageModel
    {
        /// <summary>
        /// Getter for ProductService 
        /// </summary>
        public JsonFileProductService ProductService { get; }

        /// <summary>
        /// Constructor for UpdateModel
        /// </summary>
        /// <param name="productService"></param>
        public UpdateModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        /// <summary>
        /// The data to show, bind to it for the post
        /// </summary>
        [BindProperty]
        public ProductModel Product { get; set; }
       
        /// <summary>
        /// OnGet gets frist data or default from products
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(string id)
        {
            Product = ProductService.GetAllData().FirstOrDefault(m => m.Id.Equals(id));
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

            ProductService.UpdateData(Product);

            return RedirectToPage("./Index");
        }
    }
}