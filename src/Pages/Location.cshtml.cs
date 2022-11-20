using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Location page
    /// </summary>
    public class LocationModel : PageModel
    {
        // Variable for logger
        private readonly ILogger<LocationModel> _logger;

        /// <summary>
        /// Constructor for LocationModel
        /// </summary>
        /// <param name="logger"></param>
        public LocationModel(ILogger<LocationModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// OnGet for Location
        /// </summary>
        public void OnGet()
        {
        }
    }
}