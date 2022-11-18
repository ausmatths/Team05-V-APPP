using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    /// <summary>
    /// Payment page
    /// </summary>
    public class PaymentModel : PageModel
    {
        // Variable for logger
        private readonly ILogger<PaymentModel> _logger;

        /// <summary>
        /// Constructor for PaymentModel
        /// </summary>
        /// <param name="logger"></param>
        public PaymentModel(ILogger<PaymentModel> logger)
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