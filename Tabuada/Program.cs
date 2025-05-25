// See https://aka.ms/new-console-template for more information
Console.WriteLine("## instrução while ##\n");

int numero;
int contador = 1;

Console.WriteLine("\nDigite um numero maior que zero\n");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    //loopWhile
    Console.WriteLine($"\nTabuada do {numero}:\n");
    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}

else
{
    Console.WriteLine("\nNúmero inválido! Por favor, digite um número maior que zero.");
}

Console.WriteLine("\nFim do processamento\n");
Console.ReadKey();