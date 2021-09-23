using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Digite seu nome: ");
            Console.ResetColor();
            String Nome = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Olá, ");
            Console.ResetColor();
            Console.Write(Nome);
            Console.WriteLine();
        }
    }
}
