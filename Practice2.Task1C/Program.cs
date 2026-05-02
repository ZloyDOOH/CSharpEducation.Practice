/*
 * Цикл Do While. Пусть он выводит в консоль своего же счетчика
 */

namespace Practice2.Task1C;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        // цикл спост условием. Сначала выполняем тело цикла, затем проверяем условие.
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i<10); 
    }
}