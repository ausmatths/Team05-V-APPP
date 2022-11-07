using System.Linq;

using Microsoft.Extensions.Logging;

using Moq;

using NUnit.Framework;

using ContosoCrafts.WebSite.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace UnitTests.Models.Product
{
    /// <summary>
    /// Tests index page
    /// </summary>
    public class ProductModelTests
    {
        #region TestSetup

        public static ProductModel pageModel;

        [SetUp]
        // Initialize Comment page state
        public void TestInitialize()
        {
        }

        #endregion TestSetup

        #region ProductModelSetup

        [Test]
        public void Product_String_Should_Return_Product()
        {
            // Arrange
            var data = new ProductModel()
            {
                Title = "Test Volvo",
                Description = "Test Description",
                Url = "Test Url",
                Image = "Test Image",
                CommentList = new List<CommentModel>()
            };
            
            // Act
            var r = TestHelper.ProductService.CreateData(data);
            var result = TestHelper.ProductService.GetAllData().First(x => x.Id.Equals(r.Id));

            // Assert
            var t = JsonSerializer.Deserialize<ProductModel>(data.ToString()).Title;
            var p = JsonSerializer.Deserialize<ProductModel>(result.ToString()).Title;

            Assert.AreEqual(t, p);
            
        }

        #endregion ProductModelSetup
    }
}