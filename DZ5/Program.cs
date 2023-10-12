using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    internal class Program
    {
        /// <summary>
        /// Метод для умножения двух матриц и их печати
        /// не смогла разделить на 2 метода
        /// </summary>
        /// <param name="args"></param>
       static void Main(string[] args)
        {
            Console.WriteLine("Упр 6.2 Программа, реализующая умножение двух матриц, заданных в виде двумерного массива.");

            int[,] Matrix1 = new int[2, 2];
            Matrix1[0, 0] = 1;
            Matrix1[1, 0] = 2;
            Matrix1[0, 1] = 3;
            Matrix1[1, 1] = 4;

            int[,] Matrix2 = new int[2, 2];
            Matrix2[0, 0] = 5;
            Matrix2[1, 0] = 6;
            Matrix2[0, 1] = 7;
            Matrix2[1, 1] = 8;


            int a11 = Matrix1[0, 0] * Matrix2[0, 0] + Matrix1[0, 1] * Matrix2[1, 0];
            int a12 = Matrix1[0, 0] * Matrix2[0, 1] + Matrix1[0, 1] * Matrix2[1, 1];
            int a21 = Matrix1[1, 0] * Matrix2[0, 0] + Matrix1[1, 1] * Matrix2[1, 0];
            int a22 = Matrix1[1, 0] * Matrix2[0, 1] + Matrix1[1, 1] * Matrix2[1, 1];

            int[,] Zion = new int[2, 2];
            Zion[0, 0] = a11;
            Zion[1, 0] = a12;
            Zion[0, 1] = a21;
            Zion[1, 1] = a22;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", Zion[i, j]);
                }
                Console.WriteLine();
            }
        


            Console.WriteLine("\n\nУпр 6.3\nНаписать программу, вычисляющую среднюю температуру за год.");
            Console.WriteLine("Средняя температура за год");
            int[,] Temperature = GenerateRandomTemperatures();
            int[] averageTemperatures = AverageTemperatures(Temperature);
            string[] monthNames = GetMonthNames();

            Array.Sort(averageTemperatures, monthNames); // Сортировка массива средней температуры и месяца

            Console.WriteLine("Средние температуры по месяцам:");
            for (int i = 0; i < averageTemperatures.Length; i++)
            {
                Console.WriteLine($"{monthNames[i]}: {averageTemperatures[i]}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод для генерирования рандомной температуры
        /// </summary>
        /// <returns></returns>
        static int[,] GenerateRandomTemperatures()
        {
            Random random = new Random();
            int[,] Temperature = new int[12, 30];

            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    Temperature[month, day] = random.Next(-71, 46); // -72 - самая низкая температура в России, 46 - самапя высокая
                }
            }

            return Temperature;
        }

        /// <summary>
        /// Метод вычисляющий среднюю температуру
        /// </summary>
        /// <param name="Temperature"></param>
        /// <returns></returns>
        static int[] AverageTemperatures(int[,] Temperature)
        {
            int[] averageTemperatures = new int[12]; //12 средних температур 

            for (int month = 0; month < 12; month++)
            {
                int sum = 0;
                for (int day = 0; day < 30; day++)
                {
                    sum += Temperature[month, day];
                }

                averageTemperatures[month] = sum / 30;
            }

            return averageTemperatures;
        }

        /// <summary>
        /// Метод хранящий массив месяцев
        /// </summary>
        /// <returns></returns>
        static string[] GetMonthNames()
        {
            string[] monthNames = new string[12]
            {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };
            return monthNames;
        }

    }
}
