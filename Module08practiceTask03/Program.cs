using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08practiceTask03
{
    public class Program
    {
        static void Main()
        {
            // Исходные данные - объемы продаж за пять последних месяцев
            double[] sales = { 100, 120, 130, 140, 150 };
            // Месяцы, для которых нужно сделать прогноз
            int[] futureMonths = { 6, 7, 8 };
            // Вызываем функцию, которая делает прогноз с использованием линейной регрессии
            LinearRegressionForecast(sales, futureMonths);
        }
        static void LinearRegressionForecast(double[] sales, int[] futureMonths)
        {
            int n = sales.Length;
            double sumX = 0;
            double sumY = sales.Sum();
            double sumXY = 0;
            double sumX2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumX += i + 1; // Месяцы нумеруются с 1
                sumXY += (i + 1) * sales[i];
                sumX2 += Math.Pow(i + 1, 2);
            }
            double a = (n * sumXY - sumX * sumY) / (n * sumX2 - Math.Pow(sumX, 2);
            double b = (sumY - a * sumX) / n;
            Console.WriteLine("Линейная регрессия: y = ax + b");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("Прогноз объемов продаж на будущие месяцы:");
            foreach (int month in futureMonths)
            {
                double forecast = a * month + b;
                Console.WriteLine($"Месяц {month}: {forecast}");
            }
        }
    }

}
