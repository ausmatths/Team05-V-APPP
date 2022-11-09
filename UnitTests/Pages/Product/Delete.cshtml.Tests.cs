using System.Linq;

using Microsoft.AspNetCore.Mvc;

using NUnit.Framework;

using ContosoCrafts.WebSite.Pages.Product;
using ContosoCrafts.WebSite.Models;

namespace UnitTests.Pages.Product.Delete
{
    /// <summary>
    /// Tests delete page functionality
    /// </summary>
    public class DeleteTests
    {
        #region TestSetup
        public static DeleteModel pageModel;

        [SetUp]
        // Initialize DeleteModel 
        public void TestInitialize()
        {
            pageModel = new DeleteModel(TestHelper.ProductService)
            {
            };
        }

        #endregion TestSetup

        #region OnGet
        [Test]
        // OnGet should return products if model valid
        public void OnGet_Valid_Should_Return_Products()
        {
            // Arrange

            // Act
            pageModel.OnGet("Jeep_Grand_Cherokee");

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
            Assert.AreEqual("Jeep Cherokee", pageModel.Product.Title);
        }
        #endregion OnGet

        #region OnPost
        [Test]
        // OnGet should return page if model invalid 
        public void OnPost_Valid_Model_NotValid_Return_Page()
        {
            // Arrange

            // Force an valid state
            pageModel.ModelState.AddModelError("no", "bogus error");

            // Act
            var result = pageModel.OnPost() as ActionResult;

            // Assert
            Assert.AreEqual(false, pageModel.ModelState.IsValid);
        }

        [Test]
        // OnPost should return page if not model valid
        public void OnPost_InValid_Model_NotValid_Return_Page()
        {
            // Arrange

            // Force an invalid error state
            pageModel.ModelState.AddModelError("bogus", "bogus error");

            // Act
            var result = pageModel.OnPost() as ActionResult;

            // Assert
            Assert.AreEqual(false, pageModel.ModelState.IsValid);
        }
        #endregion OnPost
    }
}