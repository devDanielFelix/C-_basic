Console.WriteLine("## Instrução if_else_if ##\n");

Console.WriteLine("\nInforme a nota do aluno\t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("\nAluno reprovado");
}
else if (nota >= 5 && nota < 6) //&& = e. >= maior igual. <= menor igual. == igualdade.
{
    Console.WriteLine("\nAluno em recuperação");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("\nAluno aprovado");
}
else if (nota >= 9) //nesse caso, também pode usar apenas o código 'else' sem o código 'nota >= 9'.
{
    Console.WriteLine("\nAluno aprovado com distinção");
}
Console.WriteLine("\nFim do processamento...");

Console.ReadKey();