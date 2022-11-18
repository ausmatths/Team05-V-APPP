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

        // Varibale for ProductDisplayModel pageModel
        public static ProductDisplayModel pageModel;

        /// <summary>
        /// Initialize ProductDisplay page state
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            // Varibale for mocklogger
            var MockLoggerDirect = Mock.Of<ILogger<IndexModel>>();

            pageModel = new ProductDisplayModel(MockLoggerDirect, TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet

        /// <summary>
        /// OnGet method should return products
        /// </summary>
        [Test]
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