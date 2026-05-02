/*
 * Напишите программу, которая вычисляет длину катетов и гипотенузы.
 * Все известные значения храните в переменных, а результаты вычислений
 * выведите в консоль.
 * Известен один катет и гипотенуза. Найти второй катет.
 */

namespace Practice1.Task6B;

using System;

class Program
{
    static void Main(string[] args)
    {
        // длина первого катета
        double catheter1 = 16;
        // длина гипотенузы
        double hypotenuse = 15;
        if (hypotenuse >= catheter1)
        {
            // длина второго катета
            double catheter2 = double.Round(Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(catheter1, 2)),2);
            // вывод реультата - длина неизвестного катета
            Console.WriteLine($"Длина неизвестного катета равна: {catheter2}");
        }
        else
        {
            Console.WriteLine("Катет не может быть больше гипотенузы");
        }
        
    }
}