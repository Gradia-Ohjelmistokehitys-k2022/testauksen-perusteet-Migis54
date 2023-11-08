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
            List<string> systemConfig;
            string winDir = "C:\\Windows";
            string path = "\\system.ini";
            //Act
            systemConfig = Files.ReadFile(systemConfig, windir, path);
            //Assert
            Assert.IsTrue(systemConfig.Count < 0);
        }