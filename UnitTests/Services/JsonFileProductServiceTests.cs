using System.Linq;

using Microsoft.AspNetCore.Mvc;

using NUnit.Framework;

using ContosoCrafts.WebSite.Models;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;

namespace UnitTests.Pages.Product.AddRating
{
    public class JsonFileProductServiceTests
    {
        IEnumerable<ProductModel> data;
        #region TestSetup

        [SetUp]
        public void TestInitialize()
        {
            this.data = TestHelper.ProductService.GetAllData();
        }

        #endregion TestSetup

        //
        #region CreateData
        [Test]
        public void CreateData_Valid_Product_Should_Return_True()
        {
            // Arrange

            // Act
            //var result = TestHelper.ProductService.CreateData(ProductModel product)
                

            // Assert
            //Assert.AreEqual(false, result);
        }

        #endregion CreateData

        #region AddRating
        //[Test]
        //public void AddRating_InValid_....()
        //{
        //    // Arrange

        //    // Act
        //    //var result = TestHelper.ProductService.AddRating(null, 1);

        //    // Assert
        //    //Assert.AreEqual(false, result);
        //}

        // ....

        [Test]
        public void AddRating_InValid_Product_Null_Should_Return_False()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.AddRating(null, 1);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void AddRating_InValid_Product_Empty_Should_Return_False()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.AddRating("", 1);

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void AddRating_Invalid_Product_Does_Not_Exist_Should_Return_False()
        {
            // Arrange

            // Act
            var result = TestHelper.ProductService.AddRating("abcd", 1);

            // Assert
            Assert.AreEqual(false, result);
        }

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
        [TearDown]
        public void TestClean()
        {
        }
        #endregion TestCleanup
    }
}