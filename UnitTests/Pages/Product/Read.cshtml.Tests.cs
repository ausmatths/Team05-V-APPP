using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using ContosoCrafts.WebSite.Pages.Product;

namespace UnitTests.Pages.Product.Read
{
    /// <summary>
    /// Testing for read pages
    /// </summary>
    public class ReadTests
    {
        #region TestSetup

        // Varibale for ReadModel pageModel
        public static ReadModel pageModel;

        /// <summary>
        /// TestInitialize for Read page testing
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            pageModel = new ReadModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet

        /// <summary>
        /// OnGet if valid should return products
        /// </summary>
        [Test]
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange

            // Act
            pageModel.OnGet("Jeep_Grand_Cherokee");

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual("Jeep Cherokee", pageModel.Product.Title);
        }

        /// <summary>
        /// OnGet if id bogus should return products
        /// </summary>
        [Test]
        public void OnGet_InValid_Id_Bougs_Should_Return_Products()
        {
            // Arrange

            // Act
            var result = pageModel.OnGet("Bogus") as RedirectToPageResult;

            // Assert
            Assert.AreEqual("./Index", result.PageName);
        }
        #endregion OnGet
    }
}