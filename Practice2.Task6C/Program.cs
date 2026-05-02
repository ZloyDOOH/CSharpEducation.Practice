/*
 * Подсчитайте процент вхождения заданного символа в сроку.
 * Строка и символ указываются через аргументы командной строки
 */


namespace Practice2.Task6C;

class Program
{
    static void Main(string[] args)
    {
        string str = args[1];
        char symbol = char.Parse(args[2]);
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