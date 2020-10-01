using System;

namespace Cos_от_x
{
    class Program
    {
        static void Display(ref double[,] arr, int size, int xmax, int ymax)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Cos ( {0," + (-xmax) + "}) = {1," + (ymax) + "}",
                string.Format("{0:N2}", arr[i, 0]), string.Format("{0:N2}", arr[i, 1]));
            }

        }
        static void Main(string[] args)
        {
            // ввод шага с клавиатуры
            Console.Write("Шаг = ");
            double dx = Convert.ToDouble(Console.ReadLine());
            // вводим диапазон
            Console.Write("min X = ");
            double xmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("max X = ");
            double xmax = Convert.ToDouble(Console.ReadLine());

            double x = xmin;// текущее значение Х
            double[,] mtrXY = new double[1000, 2];// массив аргументов
            int currIndex = 0;// текущий индекс в массиве
            // пока их в заданном диапазоне, вычисляем по формуле значение y
            int yMax = 0;// максимальное значение У при вычислении по функции
            int xMax = 0;// максимальное значение X при вычислении по функции
            while (x <= xmax)
            {
                mtrXY[currIndex, 0] = x;// запишем в массив Х
                mtrXY[currIndex, 1] = Math.Cos(x);// запишем в массив У
                // поиск максимального значения У от функции Cos(x)
                // определим длинну текущего значения с двумя знаками после запятой для ширины таблицы

                // получили максимальную длину значения X
                int currLenX = string.Format("{0:N2}", mtrXY[currIndex, 0]).Length;
                if (currIndex == 0 || xMax < currLenX) xMax = currLenX;
                // получили максимальную длину значения У
                int currLenY = string.Format("{0:N2}", mtrXY[currIndex, 1]).Length;
                if (currIndex == 0 || yMax < currLenY) yMax = currLenY;

                currIndex++;
                x += dx;// увеличение значения на шаг
            }
            // вызов функции для вывода полученных значение ХУ
            Display(ref mtrXY, currIndex, xMax + 1, yMax + 1);
            Console.ReadKey();
        }
    }
}
