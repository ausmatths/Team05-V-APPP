using System.Linq;
using NUnit.Framework;
using ContosoCrafts.WebSite.Pages.Product;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.WebSite.Pages;

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
        public void TestInitialize()
        {
            pageModel = new CreateModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet

        /// <summary>
        /// OnGet should return Products
        /// </summary>
        [Test]
        public void OnGet_Valid_Should_Create_Product()
        {
            // Arrange

            // Act
            pageModel.OnGet();

            // Assert
            Assert.AreNotEqual(null, pageModel.Product.Id);
        }
        #endregion OnGet

        #region OnPost

        /// <summary>
        /// OnPost shoould update products
        /// </summary>
        [Test]
        public void OnPost_Valid_Should_Return_Products()
        {
            // Arrange
            pageModel.Product = new ProductModel
            {
                Id = "Jeep_Grand_Cherokee",
                Title = "title",
                Description = "description",
                Url = "url",
                Image = "image"
            };

            // Act
            var result = pageModel.OnPost() as RedirectToPageResult;

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual(true, result.PageName.Contains("Index"));
        }

        /// <summary>
        /// OnPost should return false if pageModel is invalid 
        /// </summary>
        [Test]
        public void OnPost_InValid_Model_NotValid_Return_Page()
        {
            // Arrange

            // Force an invalid error state
            pageModel.ModelState.AddModelError("bogus", "bogus error");

            // Act
            pageModel.OnGet();
            var result = pageModel.OnPost() as ActionResult;

            // Assert
            Assert.AreEqual(false, pageModel.ModelState.IsValid);
        }
        #endregion OnPost
    }
}