using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C;
            bool ConvertResult;
            string str;
            Console.WriteLine("Дано квадратоное уравнение Ax^2 + Bx + C = 0");
            //----------------------------ввод коэф А-----------------------------------
            do
            {
                Console.Write("Введите A: ");
                str = Console.ReadLine();
                ConvertResult = float.TryParse(str, out A);  //Преобразование строки в число 
                if (!ConvertResult)
                {
                    Console.WriteLine("Вы ввели не число");
                    continue;
                }
                else if (A == 0)
                {
                    Console.WriteLine("Вы ввели A = 0. Квадратное уравнение стало линейным");
                    continue;
                }
            } while (!ConvertResult || A == 0);
            //--------------------------ввод коэф В------------------------------------
            do
            {
                Console.Write("Введите B: ");
                str = Console.ReadLine();
                ConvertResult = float.TryParse(str, out B);  //Преобразование строки в число 
                if (!ConvertResult)
                {
                    Console.WriteLine("Вы ввели не число");
                }
            } while (!ConvertResult);
            //--------------------------ввод коэф С------------------------------------
            do
            {
                Console.Write("Введите C: ");
                str = Console.ReadLine();
                ConvertResult = float.TryParse(str, out C);  //Преобразование строки в число 
                if (!ConvertResult)
                {
                    Console.WriteLine("Вы ввели не число");
                }

            } while (!ConvertResult);
            //-------------------------вычисление и вывод D----------------------------
            float D;
            D = B * B - 4 * A * C;
            Console.WriteLine("Дискриминант равен " + D.ToString("F3"));
            //-------------------------вычисление и вывод корней-----------------------
            if (D < 0)
            {
                Console.WriteLine("Корней у данного уравнения нет");
                Console.ReadKey();
            }
            else if (D == 0)
            {
                Console.WriteLine("Корень квадратного уравнения один и равен x = {0}", -B / (2 * A));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Корней уравнения два:");
                Console.WriteLine("x1 = {0}", (-B + Math.Sqrt(D)) / (2 * A));
                Console.WriteLine("x2 = {0}", (-B - Math.Sqrt(D)) / (2 * A));
                Console.ReadKey();
            }
        }
    }
}

