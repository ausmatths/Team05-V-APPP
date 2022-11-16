using Microsoft.Extensions.Logging;

using NUnit.Framework;

using Moq;

using ContosoCrafts.WebSite.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UnitTests.Pages.Payment

{
    /// <summary>
    /// Tests Payment page
    /// </summary>
    public class PaymentTests
    {
        #region TestSetup
        public static PaymentModel pageModel;

        [SetUp]
        // Initialises the initial state
        public void TestInitialize()
        {
            var MockLoggerDirect = Mock.Of<ILogger<PaymentModel>>();

            pageModel = new PaymentModel(MockLoggerDirect)
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
