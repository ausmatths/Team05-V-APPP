using System.Linq;

using Microsoft.Extensions.Logging;

using Moq;

using NUnit.Framework;

using ContosoCrafts.WebSite.Pages;

namespace UnitTests.Pages.ContactUs
{
    /// <summary>
    /// Tests ContctUs page
    /// </summary>
    public class ContactUsTests
    {
        #region TestSetup

        public static ContactUsModel pageModel;

        [SetUp]
        // Initialize ContactUs page state
        public void TestInitialize()
        {
            var MockLoggerDirect = Mock.Of<ILogger<ContactUsModel>>();

            pageModel = new ContactUsModel(MockLoggerDirect, TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup
    }
}