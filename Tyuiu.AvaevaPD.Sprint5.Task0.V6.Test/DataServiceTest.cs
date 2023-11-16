using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AvaevaPD.Sprint5.Task0.V6.Lib;
namespace Tyuiu.AvaevaPD.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint5\Tyuiu.AvaevaPD.Sprint5.Task0.V6\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
