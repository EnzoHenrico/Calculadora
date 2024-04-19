float num1, num2;

Console.Write("Digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
num2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Soma : {num1 + num2}");
Console.WriteLine($"Subtração: {num1 - num2}");
Console.WriteLine($"Multiplicação: {num1 * num2}");

if (num2 <= 0)
{
    Console.WriteLine("Impossivel divir por 0");
}
else
{
    Console.WriteLine($"Divisão: {num1 / num2}");
}
