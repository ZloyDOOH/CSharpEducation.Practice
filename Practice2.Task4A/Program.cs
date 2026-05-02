/*
 * Нарисуйте прямоугоьный треугольник звездочками. 
 * Чтобы высоту треугольника можно было задавать программно
 *  Пример:
 *      *
 *      **
 *      ***
 *      ****
 *      *****
 *
 */

namespace Practice2.Task4A;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите высоту треугольника: ");
        int hуightTriangle =  int.Parse(Console.ReadLine());
        for (int i = 0; i < hуightTriangle; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}