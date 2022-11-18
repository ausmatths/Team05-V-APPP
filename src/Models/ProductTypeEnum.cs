using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite.Models
{
    /// <summary>
    /// Type of the product in mock database i.e. products.json file
    /// </summary>
    public enum ProductTypeEnum
    {
        Undefined = 0,
        Amature = 55,
        Antique = 5,
        Collectable = 130,
        Commercial = 1,
    }

    /// <summary>
    /// Selects and shows the type of product
    /// </summary>
    public static class ProductTypeEnumExtensions
    {
        /// <summary>
        /// Assigns the name value to enums
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DisplayName(this ProductTypeEnum data)
        {
            return data switch
            {
                ProductTypeEnum.Amature => "Supercars",
                ProductTypeEnum.Antique => "SUV",
                ProductTypeEnum.Collectable => "Sedan",
                ProductTypeEnum.Commercial => "Hatchback",
 
                // Default, Unknown
                _ => "",
            };
        }
    }
}