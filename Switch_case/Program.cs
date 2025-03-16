// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Estutura switch case ## \n");

Console.WriteLine("Digite o valor da compra:");
var compra = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nValor da compra:" + compra);

Console.WriteLine("\nInforme o valor das parcelas:");
var parcelas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nParcelado em { parcelas } vezes ");

switch (parcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ { compra / parcelas }");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ { compra / parcelas }");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ { compra / parcelas }");
        break;
    default:
        Console.WriteLine("Parcela inválida");
        break;
    }

    Console.ReadKey();
