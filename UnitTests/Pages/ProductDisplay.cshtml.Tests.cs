using System.Linq;

using Microsoft.Extensions.Logging;

using Moq;

using NUnit.Framework;

using ContosoCrafts.WebSite.Pages;

namespace UnitTests.Pages.ProductDisplay
{
    /// <summary>
    /// Tests ProductDisplay page
    /// </summary>
    public class ProductDisplayTests
    {
        #region TestSetup

        public static ProductDisplayModel pageModel;

        [SetUp]
        // Initialize ProductDisplay page state
        public void TestInitialize()
        {
            var MockLoggerDirect = Mock.Of<ILogger<IndexModel>>();

            pageModel = new ProductDisplayModel(MockLoggerDirect, TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet
        [Test]
        // OnGet method should return products
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange

            // Act
            pageModel.OnGet();

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual(true, pageModel.Products.ToList().Any());
        }
        #endregion OnGet
    }
}