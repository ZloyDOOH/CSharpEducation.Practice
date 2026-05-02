/* Напишите программу, котораясчитывает из консоли ваше имя и
 * выводит приветственное сообщение
 */

namespace Practice1.Task3;

class Program
{
    static void Main(string[] args)
    {
        // ввод имени
        Console.Write("Введите Ваше имя: ");
        string name = Console.ReadLine();
        //вывод приветственного сообщения
        Console.WriteLine($"Привет, {name}! ");
    }
}