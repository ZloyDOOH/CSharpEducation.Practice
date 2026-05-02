/*
 * Напишите метод, который создает массив целых чисел и возвращает его.
 * Размер массива нужно передавать в качестве аргумента.
 * Вдобавок напишите метод, который выводит переданный массив на экран монитора
 */


namespace Practice2.Task9;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Введите размер массива: ");
         int sizeArr = int.Parse(Console.ReadLine());
         int[] arr = new int[sizeArr];
         for(int i=0;i<sizeArr;i++)
         {
             Console.WriteLine($"Введите {i} элемент массива: ");
             arr[i] = int.Parse(Console.ReadLine());
         }

         for (int i = 0; i < sizeArr; i++)
         {
             Console.WriteLine($"{i} элемент массива равен {arr[i]}");
         }
     
    }
}