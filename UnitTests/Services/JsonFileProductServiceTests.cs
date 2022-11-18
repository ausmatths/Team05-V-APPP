using System.Linq;
using NUnit.Framework;
using ContosoCrafts.WebSite.Models;

namespace UnitTests.Pages.Product.AddRating
{
    /// <summary>
    /// This class tests CRUDi methods and checks if the results are as expected
    /// </summary>
    public class JsonFileProductServiceTests
    {
        #region TestSetup

        /// <summary>
        /// TestInitialize
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
        }

        #endregion TestSetup

        #region DeleteData

        /// <summary>
        /// Tests DeleteData function, should return valid product
        /// </summary>
        [Test]
        public void DeleteData_Valid_Product_Should_Return_Product()
        {
            // Arrange
            var data = new ProductModel()
            {
                Title = "Test Volvo",
                Description = "Test Description",
                Url = "Test Url",
                Image = "Test Image",
            };

            // Act
            TestHelper.ProductService.CreateData(data);
            TestHelper.ProductService.DeleteData(data.Id);
            var result = TestHelper.ProductService.GetAllData().Last();
            //var result3 = TestHelper.ProductService.Get;


            // Assert
            Assert.AreNotEqual(data.Id, result.Id);
        }

        #endregion DeleteData

        #region UpdateData

        /// <summary>
        /// Tests UpdateData function, should return valid product
        /// </summary>
        [Test]
        public void UpdateData_Valid_Product_Should_Return_Product()
        {
            // Arrange
            var data = TestHelper.ProductService.GetAllData().First();

            // Act
            var result = TestHelper.ProductService.UpdateData(data);


            // Assert
            Assert.AreEqual(data.Title, result.Title);
            Assert.AreEqual(data.Description, result.Description);
            Assert.AreEqual(data.Url, result.Url);
            Assert.AreEqual(data.Image, result.Image);
        }

        /// <summary>
        /// If invalid null product is added, UpdateData should return null
        /// </summary>
        [Test]
        public void UpdateData_InValid_Product_Null_Should_Return_Null()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.UpdateData(null);

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// If invalid null product is added inside update function, UpdateData should return null
        /// </summary>
        [Test]
        public void UpdateData_InValid_Product_Inside_UpdateData_Null_Should_Return_Null()
        {
            // Arrange
            var data = new ProductModel()
            {
                Title = "Test Volvo",
                Description = "Test Description",
                Url = "Test Url",
                Image = "Test Image",
            };

            // Act
            var result = TestHelper.ProductService.CreateData(data);
            result.Id = null;
            var result1 = TestHelper.ProductService.UpdateData(result);

            // Assert
            Assert.IsNull(null, result.Id);
        }

        #endregion UpdateData

        #region CreateData

        /// <summary>
        /// Tests createData function, should return valid product
        /// </summary>
        [Test]
        public void CreateData_Valid_Product_Should_Return_Product()
        {
            // Arrange
            var data = new ProductModel()
            {
                Title = "Test Volvo",
                Description = "Test Description",
                Url = "Test Url",
                Image = "Test Image",
            };

            // Act
            var result = TestHelper.ProductService.CreateData(data);
                
            // Assert
            Assert.AreEqual(data.Title, result.Title);
            Assert.AreEqual(data.Description, result.Description);
            Assert.AreEqual(data.Url, result.Url);
            Assert.AreEqual(data.Image, result.Image);
        }

        #endregion CreateData

        #region AddRating

        /// <summary>
        /// If invalid product is added, AddRating should return false
        /// </summary>
        [Test]
        public void AddRating_InValid_Product_Null_Should_Return_False()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.AddRating(null, 1);

            // Assert
            Assert.AreEqual(false, result);
        }

        /// <summary>
        /// If Empty product is added, AddRating should return false
        /// </summary>
        [Test]
        public void AddRating_InValid_Product_Empty_Should_Return_False()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.AddRating("", 1);

            // Assert
            Assert.AreEqual(false, result);
        }

        /// <summary>
        /// If product doesn't exist, AddRating should return false
        /// </summary>
        [Test]
        public void AddRating_Invalid_Product_Does_Not_Exist_Should_Return_False()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.AddRating("abcd", 1);

            // Assert
            Assert.AreEqual(false, result);
        }

        /// <summary>
        /// If product rating 5 is added, AddRating should return true
        /// </summary>
        [Test]
        public void AddRating_Valid_Product_Rating_5_Should_Return_True()
        {
            // Arrange

            // Get the First data item
            var data = TestHelper.ProductService.GetAllData().First();
            var countOriginal = data.Ratings.Length;

            // Act
            var result = TestHelper.ProductService.AddRating(data.Id, 5);
            var dataNewList = TestHelper.ProductService.GetAllData().First();

            // Assert
            Assert.AreEqual(true, result);
            Assert.AreEqual(countOriginal + 1, dataNewList.Ratings.Length);
            Assert.AreEqual(5, dataNewList.Ratings.Last());
        }

        /// <summary>
        /// If product rating less than 0 is added, AddRating should return false
        /// </summary>
        [Test]
        public void AddRating_Valid_Product_Rating_Less_Than_0_Should_Return_False()
        {
            // Arrange

            // Get the First data item
            var data = TestHelper.ProductService.GetAllData().First();
            var countOriginal = data.Ratings.Length;

            // Act
            var result = TestHelper.ProductService.AddRating(data.Id, -1);

            // Assert
            Assert.AreEqual(false, result);
        }

        /// <summary>
        /// If product ating greater that 5 is added, AddRating should return false
        /// </summary>
        [Test]
        public void AddRating_Valid_Product_Rating_Greater_Than_5_Should_Return_False()
        {
            // Arrange

            // Get the First data item
            var data = TestHelper.ProductService.GetAllData().First();
            var countOriginal = data.Ratings.Length;

            // Act
            var result = TestHelper.ProductService.AddRating(data.Id, 6);

            // Assert
            Assert.AreEqual(false, result);
        }

        /// <summary>
        /// If valid product rating is added, AddRating should create array of ratings
        /// </summary>
        [Test]
        public void AddRating_Product_Rating_Not_Exist_Should_Create_Array()
        {
            // Arrange

            // Get the data item with null rating
            var firstNullRatingData = TestHelper.ProductService.GetAllData().Where(a => a.Ratings == null).First();

            // Act
            var result = TestHelper.ProductService.AddRating(firstNullRatingData.Id, 5);
            var newRatingData = TestHelper.ProductService.GetAllData().Where(a => a.Id == firstNullRatingData.Id).First();

            // Assert
            Assert.IsNull(firstNullRatingData.Ratings);
            Assert.AreEqual(true, result);
            Assert.AreEqual(1, newRatingData.Ratings.Length);
            Assert.AreEqual(5, newRatingData.Ratings.First());
        }

        #endregion AddRating

        #region TestCleanup

        /// <summary>
        /// Cleans up unnecessary states
        /// </summary>
        [TearDown]
        public void TestClean()
        {
        }
        #endregion TestCleanup
    }
}