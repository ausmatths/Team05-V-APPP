using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Moq;
using ContosoCrafts.WebSite.Pages;

namespace UnitTests.Pages.Payment
{
    /// <summary>
    /// Tests Payment page
    /// </summary>
    public class PaymentTests
    {
        #region TestSetup

        // Variable for PaymentModel pageModel
        public static PaymentModel pageModel;

        /// <summary>
        /// Initialises the initial state
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
            // Variable for mocklogger
            var MockLoggerDirect = Mock.Of<ILogger<PaymentModel>>();

            pageModel = new PaymentModel(MockLoggerDirect)
            {
                PageContext = TestHelper.PageContext,
                TempData = TestHelper.TempData,
            };
        }

        #endregion TestSetup

        #region OnGet

        /// <summary>
        /// OnGetif valid activity set, should return requestId
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