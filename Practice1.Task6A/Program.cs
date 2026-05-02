/*
 * Напишите программу, которая вычисляет длину катетов и гипотенузы.
 * Все известные значения храните в переменных, а результаты вычислений
 * выведите в консоль.
 * Известны два катета. Найдите гипотенузу.
 */

namespace Practice1.Task6;

using System;

class Program
{
    static void Main(string[] args)
    {
        // длина первого катета
        double catheter1 = 5;
        // длина второго катета
        double catheter2 = 5;
        // длина гипотенузы
        double hypotenuse = double.Round(Math.Sqrt(Math.Pow(catheter1, 2) + Math.Pow(catheter2, 2)),2);
        // вывод реультата - длина гипотенузы
        Console.WriteLine($"Длина гипотенузы равна: {hypotenuse}");
    }
}