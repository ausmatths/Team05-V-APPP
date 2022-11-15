using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
	public class ReviewModel : PageModel
	{
		private readonly ILogger<ReviewModel> _logger;

		public ReviewModel(ILogger<ReviewModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}
}