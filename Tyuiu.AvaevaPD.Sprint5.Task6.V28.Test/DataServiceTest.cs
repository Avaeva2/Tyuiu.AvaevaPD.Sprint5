using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AvaevaPD.Sprint5.Task6.V28.Lib;
namespace Tyuiu.AvaevaPD.Sprint5.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint5\Tyuiu.AvaevaPD.Sprint5.Task6.V28\bin\Debug\InPutDataFileTask6V28.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }

       
        
    }
}
