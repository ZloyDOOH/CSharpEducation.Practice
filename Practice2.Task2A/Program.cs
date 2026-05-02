/*
 * написать программу которая переводит метры в километры
 */

namespace Practice2.Task2A;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите колиество метров: ");
        double numberMetters = double.Parse(Console.ReadLine());
        Console.WriteLine($"{numberMetters} м = {numberMetters/1000} км");
    }
}