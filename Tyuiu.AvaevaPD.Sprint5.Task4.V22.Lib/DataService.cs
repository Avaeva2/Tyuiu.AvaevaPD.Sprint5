using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AvaevaPD.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            
            string strX = File.ReadAllText(path);
            double res = Math.Round((Math.Pow(5.23, 3) * Math.Sin(5.23) - 4 * 5.23), 3);
            return res;
        }
    }
}
