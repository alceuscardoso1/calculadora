﻿Console.WriteLine("Bem vindo à Calculadora");
Console.WriteLine();

Console.Write("Primeiro número: ");
var n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo número: ");
var n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Soma.....: {n1 + n2}");
Console.WriteLine($"Subtração: {n1 - n2}");
