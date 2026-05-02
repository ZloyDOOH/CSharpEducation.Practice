/*
 * Написать цикл for. пусть он выводит в консоль значение своего же счетчика
 */

namespace Practice2.Task1A;

class Program
{
    static void Main(string[] args)
    {
        // количество значений
        const int count = 100;
        // цикл по i от 0 до  
        
        for (int i = 0; i <= count; i++)
        {
            Console.WriteLine(i);
        }
    }
}