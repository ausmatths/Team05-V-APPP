using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
	/// <summary>
	/// Product reveiw page
	/// </summary>
	public class ReviewModel : PageModel
	{
		// Variable for logger
		private readonly ILogger<ReviewModel> _logger;

        /// <summary>
        /// Constructor for ReviewModel
        /// </summary>
        /// <param name="logger"></param>
        public ReviewModel(ILogger<ReviewModel> logger)
		{
			_logger = logger;
		}

        /// <summary>
        /// OnGet for ReviewModel
        /// </summary>
        public void OnGet()
		{
		}
	}
}