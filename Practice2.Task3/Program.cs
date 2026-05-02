/*
 * Написать программу для вычисления значения
 * (a + b - f / a) + f * a * a - (a + b)
 * Все переменные задаютс пользователем.
 * Учесть деление на 0
 */


namespace Practice2.Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение a = ");
        double a = double.Parse(Console.ReadLine());
        while (a == 0)
        {
            Console.Write("Повторите ввод, т.к. a=0. Введите значение a = ");
            a = double.Parse(Console.ReadLine());
        }
        Console.Write("Введите значение b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите значение f = ");
        double f = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"(a + b - f / a) + f * a * a - (a + b) = ({a} + {b} - {f} / {a}) + {f} * {a} * {a} - ({a} + {b}) = {(a + b - f / a) + f * a * a - (a + b)}");
    }
}