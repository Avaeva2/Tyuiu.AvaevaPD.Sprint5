using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AvaevaPD.Sprint5.Task5.V27.Lib;
namespace Tyuiu.AvaevaPD.Sprint5.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Авaева П. Д. | ИСПБ-23-1";
            // Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание: 5                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Аваева Полина Дмитриевна | ИСПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти среднее значение всех целых чисел в файле, которые делятся на 5.  *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("*  У вещественных значений округлить до трёх знаков после запятой.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\Asus\source\repos\Tyuiu.AvaevaPD.Sprint5\Tyuiu.AvaevaPD.Sprint5.Task5.V27\bin\Debug\InPutDataFileTask5V27.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение всех целых чисел в файле, которые делятся на 5 = " + res);
            Console.ReadKey();


        }
    }
}
