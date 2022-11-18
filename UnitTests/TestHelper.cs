
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Moq;
using ContosoCrafts.WebSite.Services;

namespace UnitTests
{
    /// <summary>
    /// Helper to hold the web start settings
    ///
    /// HttpClient
    /// 
    /// Action Contect
    /// 
    /// The View Data and Teamp Data
    /// 
    /// The Product Service
    /// </summary>
    public static class TestHelper
    {
        // Helper to hold the web start settings
        public static Mock<IWebHostEnvironment> MockWebHostEnvironment;

        // Helper to hold UrlHelperFactory
        public static IUrlHelperFactory UrlHelperFactory;

        // Helper to hold the HttpContextDefault
        public static DefaultHttpContext HttpContextDefault;

        // Helper to hold the WebHostEnvironment
        public static IWebHostEnvironment WebHostEnvironment;

        // Helper to hold the ModelState
        public static ModelStateDictionary ModelState;

        // Helper to hold the ActionContext
        public static ActionContext ActionContext;

        // Helper to hold the ModelMetadataProvider
        public static EmptyModelMetadataProvider ModelMetadataProvider;

        // Helper to hold the ViewData
        public static ViewDataDictionary ViewData;

        // Helper to hold the TempData
        public static TempDataDictionary TempData;

        // Helper to hold the PageContext
        public static PageContext PageContext;

        // Helper to hold the ProductService
        public static JsonFileProductService ProductService;

        /// <summary>
        /// Default Constructor
        /// </summary>
        static TestHelper()
        {
            MockWebHostEnvironment = new Mock<IWebHostEnvironment>();
            MockWebHostEnvironment.Setup(m => m.EnvironmentName).Returns("Hosting:UnitTestEnvironment");
            MockWebHostEnvironment.Setup(m => m.WebRootPath).Returns(TestFixture.DataWebRootPath);
            MockWebHostEnvironment.Setup(m => m.ContentRootPath).Returns(TestFixture.DataContentRootPath);

            HttpContextDefault = new DefaultHttpContext()
            {
                TraceIdentifier = "trace",
            };
            HttpContextDefault.HttpContext.TraceIdentifier = "trace";

            ModelState = new ModelStateDictionary();

            ActionContext = new ActionContext(HttpContextDefault, HttpContextDefault.GetRouteData(), new PageActionDescriptor(), ModelState);

            ModelMetadataProvider = new EmptyModelMetadataProvider();
            ViewData = new ViewDataDictionary(ModelMetadataProvider, ModelState);
            TempData = new TempDataDictionary(HttpContextDefault, Mock.Of<ITempDataProvider>());

            PageContext = new PageContext(ActionContext)
            {
                ViewData = ViewData,
                HttpContext = HttpContextDefault
            };

            ProductService = new JsonFileProductService(MockWebHostEnvironment.Object);

            JsonFileProductService productService;

            productService = new JsonFileProductService(TestHelper.MockWebHostEnvironment.Object);
        }
    }
}