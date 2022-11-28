using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Acknowledgement page for Thank you description
    /// </summary>
    public class AcknowledgementModel : PageModel
    {
        // Variable for logger
        private readonly ILogger<AcknowledgementModel> _logger;

        /// <summary>
        /// Constructor for AcknowledgementModel
        /// </summary>
        /// <param name="logger"></param>
        public AcknowledgementModel(ILogger<AcknowledgementModel> logger)
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