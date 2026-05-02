/*
 * написать цикл while. Пусть он выводит в консоль значения своего же счетчика 
 */

namespace Practice2.Task1B;

class Program
{
    static void Main(string[] args)
    {
        // задаем начальное значение счетчика
        int i = 0;
        // цикл с предусловием. Сначала проверяем условие, затем выполняем тело цикла
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}