﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvaevaPD.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\InPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {

                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path)) // открываем файл для чтения
            {
                string line;
                while ((line = reader.ReadLine()) != null) // читаем строку за строкой
                {
                    

                    
                    for (int i = 0; i < line.Length; i++) // проходим по каждому байту строки
                    {
                        if (line[i] >= 192 && line[i] <= 255)
                        {
                            strLine = strLine + line[i];
                        }


                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}