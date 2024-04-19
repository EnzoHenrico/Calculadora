float num1 = 0, num2 = 0, choice = 0;
bool valid_choice = true;

Console.WriteLine("Calculadora de operações básicas!");
Console.WriteLine("---------------------------------");
Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
Console.Write("\nEscolha qual operação: ");

do
{
    choice = float.Parse(Console.ReadLine());
    if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
    {
        Console.WriteLine("\nDecisão inválida, tente novamente:\n");
        valid_choice = false;
    }
    else
    {
        valid_choice = true;
    }
}
while (!valid_choice);

do
{
    Console.Write("Digite o primeiro numero: ");
    num1 = float.Parse(Console.ReadLine());
   
    Console.Write("Digite o segundo numero: ");
    num2 = float.Parse(Console.ReadLine());

    if (choice == 4 && num2 == 0)
    {
        Console.WriteLine("\nImpossível dividir por 0, tente novamente.\n");
        valid_choice = false;
    }
    else
    {
        valid_choice = true;
    }
}
while (!valid_choice);

if (choice == 1) Console.WriteLine($"\nResultado: {num1 + num2}");
if (choice == 2) Console.WriteLine($"\nResultado: {num1 - num2}");
if (choice == 3) Console.WriteLine($"\nResultado: {num1 * num2}");
if (choice == 4) Console.WriteLine($"\nResultado: {num1 / num2}");

Console.ReadKey();