using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Moq;
using ContosoCrafts.WebSite.Pages;

namespace UnitTests.Pages.Review

{
    /// <summary>
    /// Tests Review page
    /// </summary>
    public class ReviewTests
    {
        #region TestSetup
        public static ReviewModel pageModel;

        /// <summary>
        /// Initialises the initial state
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            // Variable for mocklogger
            var MockLoggerDirect = Mock.Of<ILogger<ReviewModel>>();

            pageModel = new ReviewModel(MockLoggerDirect)
            {
                PageContext = TestHelper.PageContext,
                TempData = TestHelper.TempData,
            };
        }

        #endregion TestSetup

        #region OnGet

        /// <summary>
        /// OnGet if valid activity set should return requestId
        /// </summary>
        [Test]
        public void OnGet_Valid_Activity_Set_Should_Return_RequestId()
        {
            // Arrange

            // Act
            pageModel.OnGet();

            // Reset

            // Assert
            Assert.AreEqual(true, pageModel.ModelState.IsValid);
        }

        #endregion OnGet
    }
}