using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число n (n > 2):");
        int n = int.Parse(Console.ReadLine());

        if (n <= 2)
        {
            Console.WriteLine("n должно быть больше 2.");
            return;
        }
        this is not working
        Console.WriteLine("Введите целые числа a, b и c:");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());

        if (CheckFermat(a, b, c, n))
        {
            Console.WriteLine("Великая теорема Ферма подтверждается для введенных значений.");
        }
        else
        {
            Console.WriteLine("Великая теорема Ферма опровергается для введенных значений.");
        }
    }

    static bool CheckFermat(int a, int b, int c, int n)
    {
        return Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);
    }
}