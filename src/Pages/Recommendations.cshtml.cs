using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Recommendation page
    /// </summary>
    public class RecommendationsModel : PageModel
    {
        // Variable for logger
        private readonly ILogger<RecommendationsModel> _logger;

        /// <summary>
        /// Constructor for RecommendationsModel
        /// </summary>
        /// <param name="logger"></param>
        public RecommendationsModel(ILogger<PrivacyModel> logger)
        {
            _logger = _logger;
        }

        /// <summary>
        /// OnGet for RecommendationsModel
        /// </summary>
        public void OnGet()
        {
        }
    }
}