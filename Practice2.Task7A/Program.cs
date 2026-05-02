/*
 * перевод строки в верхний регистр:f -> F
 */

namespace Practice2.Task7A;

class Program
{
    static void Main(string[] args)
    {
        string str = "asdfghjkolkkkjjhhggg";
        Console.WriteLine($"Результат перевода строки \"{str}\" в верхний регистр \"{str.ToUpper()}\"");
    }
}