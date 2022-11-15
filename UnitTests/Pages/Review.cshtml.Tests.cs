using Microsoft.Extensions.Logging;

using NUnit.Framework;

using Moq;

using ContosoCrafts.WebSite.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnitTests.Pages.Review

{
    /// <summary>
    /// Tests Review page
    /// </summary>
    public class ReviewTests
    {
        #region TestSetup
        public static ReviewModel pageModel;

        [SetUp]
        // Initialises the initial state
        public void TestInitialize()
        {
            var MockLoggerDirect = Mock.Of<ILogger<ReviewModel>>();

            pageModel = new ReviewModel(MockLoggerDirect)
            {
                PageContext = TestHelper.PageContext,
                TempData = TestHelper.TempData,
            };
        }

        #endregion TestSetup

        #region OnGet
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
