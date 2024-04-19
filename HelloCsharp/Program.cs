float num1 = 0, num2 = 0, num3 = 0, num4 = 0, result = 0;
string choice = "";

Console.WriteLine("Calculadora de operações básicas com 4 números!");
Console.WriteLine("---------------------------------");
Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
Console.Write("\nEscolha qual operação: ");

do
{
    choice = Console.ReadLine();
    if (choice != "1" || choice != "2" || choice != "3" || choice != "4")
    {
        Console.WriteLine("\nOpção inválida, tente novamente:\n");
    }
}
while (choice != "1" || choice != "2" || choice != "3" || choice != "4");


Console.Write("Digite o primeiro numero: ");
num1 = float.Parse(Console.ReadLine());

do 
{
    Console.Write("Digite o segundo numero: ");
    num2 = float.Parse(Console.ReadLine());
    if (num2 == 0)
    {
        Console.WriteLine("\nEste operador não pode ser 0, tente novamente:\n");
    }
} while (num2 == 0);

do 
{
    Console.Write("Digite o terceiro numero: ");
    num3 = float.Parse(Console.ReadLine());
    if (num3 == 0)
    {
        Console.WriteLine("\nEste operador não pode ser 0, tente novamente:\n");
    }
} while (num3 == 0);

do
{
    Console.Write("Digite o quearto numero: ");
    num4 = float.Parse(Console.ReadLine());
    if (num4 == 0)
    { 
        Console.WriteLine("\nEste operador não pode ser 0, tente novamente:\n"); 
    }
}
while (num4 == 0);

if (choice == "1") {
    result = num1 + num2 + num3 + num4;
}
if (choice == "2") 
{
    result = num1 - num2 - num3 - num4;
}
if (choice == "3") 
{
    result = num1 * num2 * num3 * num4;
}
if (choice == "4")
{
    result = ((num1 / num2) / num3) / num4;
}

Console.WriteLine($"\nResultado: {result}");

Console.ReadKey();