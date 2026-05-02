/*
 * перевод строки в нижний регистр F->f 
 */

namespace Practice2.Task7B;

class Program
{
    static void Main(string[] args)
    {
        string str = "FSFSDFSDFSDFDFHFHDHDFGDFG";
        Console.WriteLine($"Результат перевода строки \"{str}\" в верхний регистр \"{str.ToLower()}\"");
    }
}