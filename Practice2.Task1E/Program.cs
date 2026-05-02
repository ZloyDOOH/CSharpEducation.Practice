/*
 * Цикл While, в котором у пользователя запрашиваютс слова, 
 * а затем выводится полная фраза, слова в которой разделены пробелами
 */

namespace Practice2.Task1E;

class Program
{
    static void Main(string[] args)
    {
        int countWords;
        // вводим количество слов в фразе
        Console.Write("Введите количество слов в фразе: ");
        countWords = int.Parse(Console.ReadLine());
        // создаем массив слов размерностью равной количеству слов во фразе
        string[] word = new string[countWords];
        int i = 0;
        while (i<word.Length)
        {
            Console.Write($"Введите {i + 1} слово: ");
            word[i] = Console.ReadLine();
            i++;
        }
        Console.WriteLine();
        i = 0;
        Console.Write("Фраза целиком:");
        while (i < word.Length)
        {
            Console.Write($" {word[i]}");
            i++;
        }
    }
}