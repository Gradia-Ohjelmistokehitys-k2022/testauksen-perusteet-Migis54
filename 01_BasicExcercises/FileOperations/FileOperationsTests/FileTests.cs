using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using FileOperations;
using System.IO;

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
            Assert.IsTrue(systemConfig.Count > 0);
        }
        [TestMethod]
        public void ReadFile_WrongPath_throwexception() 
        {
            List<string> systemConfig = new List<string>();
            string winDir = "C:\\Windows";
            string path = "\\sywhwieghghwstem.ini";
            try 
            {
                systemConfig = File.ReadFile(systemConfig, winDir, path);
            }
            catch (ArgumentOutOfRangeException) 
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => File.ReadFile(systemConfig, winDir, path));
            }
            
        }
        [TestMethod]
        public void ReadFile_WhenDirectoryDoesntExist_throwException() 
        {
            List<string> systemConfig = new List<string>();
            string winDir = "";
            string path = "\\system.ini";
            try 
            {
                systemConfig = File.ReadFile(systemConfig,winDir,path);
            }
            catch (DirectoryNotFoundException)
            {
                Assert.ThrowsException<DirectoryNotFoundException>(() => File.ReadFile(systemConfig, winDir,path));
            }
            
        }
    }
}