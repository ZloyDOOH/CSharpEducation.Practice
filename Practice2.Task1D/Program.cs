/*
 * цикл for, в котором у пользователя запрашиваются слова,
 * затем выводится полная фраза,
 * слова в которой разделены пробелами 
 */

namespace Practice2.Task1D;

class Program
{
    static void Main(string[] args)
    {
        int countWords;
        // вводим количество слов в фразе
        Console.Write("Введите количество слов в фразе: ");
        countWords = int.Parse(Console.ReadLine());
        string[] word = new string[countWords];
        for (int i = 0; i < countWords; i++)
        {
            Console.Write($"Введите {i + 1} слово: ");
            word[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.Write("Фраза целиком:");
        for (int i = 0; i < countWords; i++)
            Console.Write($" {word[i]}");
    }
}