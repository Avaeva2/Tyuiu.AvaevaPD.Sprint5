using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvaevaPD.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27

    {
        public double LoadFromDataFile(string path)
        {

            double sum = 0;
            int count = 0;

            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] numbers = line.Split(' ');

                foreach (string number in numbers)
                {
                    double n = double.Parse(number);
                    if (n % 5 == 0)
                    {
                        sum += n;
                        count++;
                    }



                }

            }
            double average = sum / count;
            return average;
           

        }
        
    }

}


   

