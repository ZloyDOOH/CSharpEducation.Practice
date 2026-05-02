/*
 * делает заглавную букву в слове
 * 
 */

namespace Practice2.Task7C;

class Program
{
    static void Main(string[] args)
    {
        string str = "asdfghjkolkkkjhghgGGGG";
        Console.WriteLine($"Результат перевода строки \"{str}\" первая буква верхний регистр, остальные в нижний: \"{str.Substring(0,1).ToUpper()+str.Substring(1,str.Length-1).ToLower()}\"");
        
        
        Console.WriteLine(str);
    }
}