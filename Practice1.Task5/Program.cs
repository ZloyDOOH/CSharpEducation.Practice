/*
 *Напишите программу
 *
 * 
 */


namespace Practice1.Task5;

using System;

class Program
{
    static void Main(string[] args)
    {
        const double radius = 10;
        const double pi = Math.PI;
        double squareCircle = double.Round(pi * radius * radius,2);
        Console.WriteLine($"Площадь круга равна {squareCircle}");
    }
}