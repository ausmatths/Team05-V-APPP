using System;
using NUnit.Framework;
using ContosoCrafts.WebSite.Models;

namespace UnitTests.Models.Product
{
    /// <summary>
    /// This class tests ProductTypeEnum page in Models
    /// </summary>
    public class ProductTypeEnumTests
    {
        #region TestSetup
        /// <summary>
        /// TestInitialize for ProductTypeEnums
        /// </summary>
        [SetUp]
        public void TestInitialize()
        {
        }

        #endregion TestSetup

        #region AmatureEnum

        /// <summary>
        /// DisplayName 'Amature', should return 'Supercars'
        /// </summary>
        [Test]
        public void DisplayName_Valid_Amature_Should_Return_String_Supercars()
        {
            // Arrange
            ProductTypeEnum productTypeEnum = ProductTypeEnum.Amature;
            String data = "Supercars";

            // Act
            String result = ProductTypeEnumExtensions.DisplayName(productTypeEnum);

            //Assert
            Assert.AreEqual(data, result);
        }
        #endregion AmatureEnum

        #region AntiqueEnum

        /// <summary>
        /// DisplayName 'Antique', should return 'SUV'
        /// </summary>
        [Test]
        public void DisplayName_Valid_Antique_Should_Return_String_SUV()
        {
            // Arrange
            ProductTypeEnum productTypeEnum = ProductTypeEnum.Antique;
            String data = "SUV";

            // Act
            String result = ProductTypeEnumExtensions.DisplayName(productTypeEnum);

            //Assert
            Assert.AreEqual(data, result);
        }
        #endregion AntiqueEnum

        #region CollectableEnum

        /// <summary>
        /// DisplayName 'Collectable', should return 'Sedan'
        /// </summary>
        [Test]
        public void DisplayName_Valid_Collectable_Should_Return_String_Sedan()
        {
            // Arrange
            ProductTypeEnum productTypeEnum = ProductTypeEnum.Collectable;
            String data = "Sedan";

            // Act
            String result = ProductTypeEnumExtensions.DisplayName(productTypeEnum);

            //Assert
            Assert.AreEqual(data, result);
        }
        #endregion CollectableEnum

        #region CommercialEnum
        /// <summary>
        /// DisplayName 'Commercial', should return 'Hatchback'
        /// </summary>
        [Test]
        public void DisplayName_Valid_Commercial_Should_Return_String_Hatchback()
        {
            // Arrange
            ProductTypeEnum productTypeEnum = ProductTypeEnum.Commercial;
            String data = "Hatchback";

            // Act
            String result = ProductTypeEnumExtensions.DisplayName(productTypeEnum);

            //Assert
            Assert.AreEqual(data, result);
        }
        #endregion CommercialEnum

        #region emptyEnum

        /// <summary>
        /// DisplayName empty, should return empty string
        /// </summary>
        [Test]
        public void DisplayName_Valid_Undefined_Should_Return_Empty_String()
        {
            // Arrange
            ProductTypeEnum productTypeEnum = ProductTypeEnum.Undefined;
            String data = "";

            // Act
            String result = ProductTypeEnumExtensions.DisplayName(productTypeEnum);

            //Assert
            Assert.AreEqual(data, result);
        }

        #endregion emptyEnum
    }
}
