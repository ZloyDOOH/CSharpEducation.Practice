namespace Practice2.Task13;

class Program
{
    static void Main(string[] args)
    {
        // рахмер массива
        int row = 8;
        int col = 10;
        // метод создания и заполнения массива    
        int[,] InitArr(int row, int col)
            {
                Random random = new Random();
                int[,] arr = new int[row, col];
                for(int i=0;i<row;i++)
                    for(int j=0;j<col;j++)
                        // заполняем массив случайными числами от 0 до 100
                        arr[i, j] = random.Next(0, 100);
                return arr;
            }
        // метод вывода массива
        void WriteArr(int row, int col,  int[,] arr)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arr[i,j]}        ");
                }
                Console.WriteLine();

            }
        }
        InitArr(row, col);
        WriteArr(row, col, InitArr(row, col));
        
    }
}