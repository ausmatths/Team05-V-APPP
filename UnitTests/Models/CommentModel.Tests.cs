using System.Linq;
using NUnit.Framework;
using ContosoCrafts.WebSite.Models;
using System.Collections.Generic;

namespace UnitTests.Models.Comment
{
    /// <summary>
    /// Tests CommentModel page
    /// </summary>
    public class CommentModelTests
    {
        #region TestSetup

        [SetUp]
        // Initialize Comment page state
        public void TestInitialize()
        {
        }

        #endregion TestSetup

        #region Comment
        /// <summary>
        /// Tests Comment function, should return valid comment
        /// </summary>
        [Test]
        public void Comment_Get_Should_Return_Product_Comment()
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
            var commentModel = new CommentModel();
            commentModel.Comment = "Comment here";
            data.CommentList.Add(commentModel);
            // Act
            var r = TestHelper.ProductService.CreateData(data);
            var result = TestHelper.ProductService.GetAllData().First(x=>x.Id.Equals(r.Id));

            // Assert
            Assert.AreEqual(data.CommentList.Count, result.CommentList.Count);
            Assert.AreEqual(data.CommentList.First().Comment, result.CommentList.First().Comment);
            Assert.AreEqual(r.CommentList.First().Id, result.CommentList.First().Id);
        }

        #endregion Comment
    }
}