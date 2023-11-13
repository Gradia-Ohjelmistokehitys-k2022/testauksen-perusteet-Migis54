using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using FileOperations;
namespace FileOperations.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
        {
            //Arrange
            List<string> systemConfig = new List<string>();
            string winDir = "C:\\Windows";
            string path = "\\system.ini";
            //Act
            systemConfig = File.ReadFile(systemConfig, winDir, path);
            //Assert
            Assert.AreNotEqual(systemConfig.Count, 0);
        }
        [TestMethod]
        public void CheckThat_ListIsNotEmpty() 
        {
            List<string> systemConfig = new List<string>();
            systemConfig.Add("x");
            Assert.AreNotEqual(systemConfig.Count, 0);
        }
        [TestMethod]
        public void CheckThat_FilePath_IsCorrect() 
        {
            string AssumedFilepath = "\\system.ini";
            string Filepath = "\\system.ini";
            Assert.AreEqual(Filepath, AssumedFilepath);

        }
    }
}