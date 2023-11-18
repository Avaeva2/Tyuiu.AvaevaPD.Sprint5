﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint5.Task3.V10.Lib;
using System.IO;
namespace Tyuiu.AvaevaPD.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint5\Tyuiu.AvaevaPD.Sprint5.Task3.V10\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
