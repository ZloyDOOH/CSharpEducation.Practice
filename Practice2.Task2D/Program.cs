/*
 * Написать программу которая переводит градусы Цельсия в градусы по Фаренгейту
 */


namespace Practice2.Task2D;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите температуру в градусах Цельсия: ");
        double degCelsiy = double.Parse(Console.ReadLine());
        Console.WriteLine($"температура {degCelsiy} град Цельсия = температуре в {degCelsiy * 9 / 5 + 32} град Фаренгейта");
    }
}