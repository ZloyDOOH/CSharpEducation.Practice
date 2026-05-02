/*
 * Подсчитайте процент вхождения заданного символа в сроку.
 * Строка и символ указываются пользователем в консоли
 */

namespace Practice2.Task6B;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите слово в котором необходимо посчитать колтчество символов: ");
        string str = Console.ReadLine();
        Console.Write("Введите символ который необходимо посчитать: ");
        char symbol = char.Parse(Console.ReadLine());
        int lengthStr =  str.Length;
        int count = 0;
        for (int i = 0; i < lengthStr; i++)
        {
            if (str[i] == symbol)
            {
                count++;
            }
        } 
        Console.WriteLine($"Символ \"{symbol}\" входит в слово \"{str}\" длиной {lengthStr} символов: {count} раза или {Math.Round((double)count / (double)lengthStr * 100, 2)} %");
    }
}