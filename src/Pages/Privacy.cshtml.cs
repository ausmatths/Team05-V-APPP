using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Privacy page fro privacy description
    /// </summary>
    public class PrivacyModel : PageModel
    {
        // Variable for logger
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// Constructor for PrivacyModel
        /// </summary>
        /// <param name="logger"></param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// OnGet for PrivacyModel
        /// </summary>
        public void OnGet()
        {
        }
    }
}