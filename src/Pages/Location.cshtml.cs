using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Payment page
    /// </summary>
    public class LocationModel : PageModel
    {
        // Variable for logger
        private readonly ILogger<LocationModel> _logger;

        /// <summary>
        /// Constructor for PaymentModel
        /// </summary>
        /// <param name="logger"></param>
        public LocationModel(ILogger<LocationModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// OnGet for payments
        /// </summary>
        public void OnGet()
        {
        }
    }
}