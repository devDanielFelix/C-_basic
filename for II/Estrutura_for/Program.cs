Console.WriteLine("## Estrutura FOR ##");

for (int x = 0; x<=5; x++)
{
    for (int y = 0; y<=5; y++)
    {
        Console.Write($"({x}, {y}) ");
    }
    Console.WriteLine();
}
Console.WriteLine("Fim do Procesamento!");
Console.ReadKey();