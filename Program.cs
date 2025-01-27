Console.WriteLine("Bem vindo à Calculadora");
Console.WriteLine();

Console.Write("Primeiro número: ");
var n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo número: ");
var n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Terceiro número: ");
var n3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Resultado é: {n1 - n2 - n3}");