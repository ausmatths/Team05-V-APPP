using System.Linq;
using NUnit.Framework;
using ContosoCrafts.WebSite.Pages.Product;

namespace UnitTests.Pages.Product.Create
{
    /// <summary>
    /// Tests create page functinality
    /// </summary>
    public class CreateTests
    {
        #region TestSetup

        // Variable for CreateModel pageModel
        public static CreateModel pageModel;

        [SetUp]
        // Initialize CreateModel
        public void TestInitialize()
        {
            pageModel = new CreateModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet

        /// <summary>
        ///  OnGet should return products if model valid
        /// </summary>
        [Test]
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange
            var oldCount = TestHelper.ProductService.GetAllData().Count();

            // Act
            pageModel.OnGet();

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual(oldCount + 0, TestHelper.ProductService.GetAllData().Count());
        }
        #endregion OnGet
    }
}