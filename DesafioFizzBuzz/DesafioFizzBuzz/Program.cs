﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Desafio FizzBuzz ##\n");
Console.ReadKey();

int i = 1;

for ( i = 1; i < 30; i++) 
{
  if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }  
}
Console.ReadKey();