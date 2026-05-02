/*
 * Напишите программу, которая считывает из консоли фразу и сохраняет ее.
 * Затем считывает вторую фразу и выводит ее на экран консоли обе этифразы
 * объеиненные в одно предложение. (пример: введи "Привет", а затем "мир".
 * В консоли отобразиться "Привет мир").
 */

namespace Practice1.Task4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первую фразу: ");
        string FirstPhrase = Console.ReadLine();
        Console.Write("Введите вторую фразу: ");
        string SecontPhrase = Console.ReadLine();
        Console.WriteLine($"{FirstPhrase} {SecontPhrase}");
    }
}