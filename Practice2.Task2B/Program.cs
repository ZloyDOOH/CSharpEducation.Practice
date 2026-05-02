/*
 * Написать программу которая переводит километры в сантиметры 
 */

namespace Practice2.Task2B;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите колиество километров: ");
        double numberKilometter = double.Parse(Console.ReadLine());
        Console.WriteLine($"{numberKilometter} км = {numberKilometter * 100000} см");
    }
}