// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Informe um número inteiro\t");
int numero = Convert.ToInt32 (Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine("\n" + numero + " é par");
        break;
    case 1:
        Console.WriteLine("\n" + numero + " é impar");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
