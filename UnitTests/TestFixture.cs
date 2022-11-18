using System.IO;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTests
{
    /// <summary>
    /// This class sets up a teardown method
    /// </summary>
    [SetUpFixture]
    public class TestFixture
    {
        // Path to the Web Root
        public static string DataWebRootPath = "./wwwroot";

        // Path to the data folder for the content
        public static string DataContentRootPath = "./data/";

        /// <summary>
        /// Run this code once when the test harness starts up.
        /// This will copy over the latest version of the database files
        /// C:\repos\5110\ClassBaseline\UnitTests\bin\Debug\net5.0\wwwroot\data
        /// C:\repos\5110\ClassBaseline\src\wwwroot\data
        /// C:\repos\5110\ClassBaseline\src\bin\Debug\net5.0\wwwroot\data
        /// </summary>
       [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            // var DataWebPath = "../../../../src/bin/Debug/net5.0/wwwroot/data";
            var DataWebPath = "../../../../src/wwwroot/data";

            // var for DataUTDirectory
            var DataUTDirectory = "wwwroot";

            // var for DataUTPath 
            var DataUTPath = DataUTDirectory + "/data";

            // Delete the Detination folder
            if (Directory.Exists(DataUTDirectory))
            {
                Directory.Delete(DataUTDirectory, true);
            }
            
            // Make the directory
            Directory.CreateDirectory(DataUTPath);

            // Copy over all data files
            var filePaths = Directory.GetFiles(DataWebPath);
            foreach (var filename in filePaths)
            {
                // saves the name of the file
                string OriginalFilePathName = filename.ToString();

                // saves the original file path name
                var newFilePathName = OriginalFilePathName.Replace(DataWebPath, DataUTPath);

                File.Copy(OriginalFilePathName, newFilePathName);
            }
        }

        /// <summary>
        /// To be run after any test
        /// </summary>
        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
        }
    }
}