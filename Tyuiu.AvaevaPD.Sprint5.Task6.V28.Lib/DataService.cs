using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AvaevaPD.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            string input = "1234 это просто 487 строка 432123 с 34509 циф 3244 ра 23 ми 43 4567.";
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
                else if (count >= 4)
                {
                    break;
                }
            }
            Console.WriteLine($"Количество четырехзначных чисел: {count}");
            return count;
        }
    }
    
}
