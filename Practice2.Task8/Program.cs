/*
 * Составить алгоритм увеличения всех трех, введенных с клавиатуры, 
 *переменных на 5, если среди них есть хотябы две равные. 
 * В противном случае выдать ответ "равных нет".
 */

namespace Practice2.Task8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первую переменную: ");
        int variable1 = int.Parse(Console.ReadLine());
        Console.Write("Введите вторую переменную: ");
        int variable2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третью переменную: ");
        int variable3= int.Parse(Console.ReadLine());
        if ((variable1 == variable2) | (variable2 == variable3) | (variable1 == variable3))
        {
            Console.WriteLine($"Первая переменная:{5 * variable1} Вторая переменная: {5 * variable2} Третья переменная: {5 * variable3}");
        }
        else
        {
            Console.WriteLine("равных нет");
        }
    }
}