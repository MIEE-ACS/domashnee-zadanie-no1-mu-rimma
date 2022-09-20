// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static string Change1(string A, string C)
    {
        A = C;
        Console.WriteLine($"A={A}");
        return A;
    }
    static string Change2(string A, string B)
    {
        B = A;
        Console.WriteLine($"B={B}");
        return B;
    }
    static string Change3(string B, string C)
    {
        C = B;
        Console.WriteLine($"C={C}");
        return C;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите переменную A:");
        string A = Console.ReadLine();
        Console.WriteLine("Введите переменную B:");
        string B = Console.ReadLine();
        Console.WriteLine("Введите переменную C:");
        string C = Console.ReadLine();
        Change1(A, C);
        Change2(A, B);
        Change3(B, C);
    }
}

