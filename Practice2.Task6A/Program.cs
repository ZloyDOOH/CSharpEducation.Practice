/*
 * Подсчитайте процент вхождения заданного символа в сроку.
 * Строка и символ указываются программно
 */


namespace Practice2.Task6A;

using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "asdfaaarer77777";
        int lengthStr =  str.Length;
        char symbol = 'a';
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