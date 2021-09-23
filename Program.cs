using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nome; 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Digite seu nome: ");
            Console.ResetColor();
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Olá, ");
            Console.ResetColor();
            Console.Write(Nome);
            Console.WriteLine();
        }
    }
}
