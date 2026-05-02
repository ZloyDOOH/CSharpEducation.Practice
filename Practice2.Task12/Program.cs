namespace Practice2.Task12;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк массива :");
        int arrSize = int.Parse(Console.ReadLine());
        string[] arr = new string[arrSize];
        Console.WriteLine("Введите массив строк:");
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write($"Введите {i} строку массива: ");
            arr[i]=Console.ReadLine();
        }

        for (int i = 0; i < arrSize; i++)
        {
            Console.WriteLine($"{i} строка массива - это \"{arr[i]}\"");
        }    
    }

}