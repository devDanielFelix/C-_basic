Console.WriteLine("## estrutura de repetição for ##");

int numero, resultado;

Console.Write("Digite um número para ver a tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido.");
}