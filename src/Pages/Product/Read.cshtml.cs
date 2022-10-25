using System.Linq;

using Microsoft.AspNetCore.Mvc.RazorPages;

using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages.Product
{
    public class ReadModel : PageModel
    {
        public JsonFileProductService ProductService { get; }

        public ReadModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public ProductModel Product;

        public void OnGet(string id)
        {
            Product = ProductService.GetAllData().FirstOrDefault(m => m.Id.Equals(id));
        }
    }
}