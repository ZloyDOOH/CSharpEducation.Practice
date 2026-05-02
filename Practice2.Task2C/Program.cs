/*
 * Написать программу которая переводит м/с в км/час
 */

namespace Practice2.Task2C;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите скорость в м/с: ");
        double numberMetSec = double.Parse(Console.ReadLine());
        Console.WriteLine($"{numberMetSec} м/с = {numberMetSec *3600 / 1000} км/час");
    }
}