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

        // variable for ContactUsModel pageModel
        public static ContactUsModel pageModel;

        /// <summary>
        /// Initialize ContactUs page state
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            // Variable for mocklogger
            var MockLoggerDirect = Mock.Of<ILogger<ContactUsModel>>();

            pageModel = new ContactUsModel(MockLoggerDirect, TestHelper.ProductService)
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