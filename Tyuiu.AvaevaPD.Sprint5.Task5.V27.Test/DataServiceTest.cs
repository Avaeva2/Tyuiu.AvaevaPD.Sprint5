using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AvaevaPD.Sprint5.Task5.V27.Lib;
namespace Tyuiu.AvaevaPD.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint5\Tyuiu.AvaevaPD.Sprint5.Task5.V27\bin\Debug\InPutDataFileTask5V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
