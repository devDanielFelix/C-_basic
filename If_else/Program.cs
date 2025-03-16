// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Instrução if_else basic ##\n");

Console.WriteLine("## Qual a sua idade? ##\n");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 16)
{
    Console.WriteLine("\nVocê pode votar");
}
else
{
    Console.WriteLine("\nVocê não pode votar");
}

Console.ReadKey();