/*
 * Напишите программу сравнения двух целых чисел. 
 * Ввод осуществляйте через консоль
 */

namespace Practice2.Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine());
        if (number1 == number2)
        {
            Console.WriteLine($"Первое число ({number1}) равно второму числу ({number2})");
        }
        else
        {
            if (number1 > number2)
                Console.WriteLine($"Первое число ({number1}) больше второго числа ({number2})");
            else
                Console.WriteLine($"Первое число ({number1}) меньше второго числа ({number2})");
        }
    }
}