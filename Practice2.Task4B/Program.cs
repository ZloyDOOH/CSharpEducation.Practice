/*
 * Чтобы высоту треугольника можно было задавать программно
 *  Пример:
 *           *
 *          **
 *         ***
 *        ****
 *       *****
 *
 */

namespace Practice2.Task4B;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите высоту треугольника: ");
        int hуightTriangle =  int.Parse(Console.ReadLine());
        for (int i = 0; i < hуightTriangle; i++)
        {
            for (int j = 0; j < hуightTriangle; j++)
                if (j < hуightTriangle - i - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            Console.WriteLine("");
        }
    }
}