using Calculator;
using System;
Initialization initialization = new Initialization();

while (true)
{
    Console.WriteLine("Введите значение для первого числа");
    string FirstInput = Console.ReadLine();
    int num1 = int.Parse(FirstInput);
    Console.WriteLine("Введите значение для второго числа");
    string SecondInput = Console.ReadLine();
    int num2 = int.Parse(SecondInput);
    Console.WriteLine("Выберите операцию:\n+\n-\n*\n/");
    string ChoseInput = Console.ReadLine();
    if (ChoseInput == "+")
    {
        Console.WriteLine(initialization.Sum(num1, num2));
    }
    else if (ChoseInput == "-")
    {
        Console.WriteLine(initialization.Subtraction(num1, num2));
    }
    else if (ChoseInput == "*")
    {
        Console.WriteLine(initialization.Multiplication(num1, num2));
    }
    else if (ChoseInput == "/")
    {
        Console.WriteLine(initialization.Division(num1, num2));
    }
    Console.WriteLine("Хотите закончить программу?(да/нет)");
    string Chose = Console.ReadLine();
    if (Chose == "да") 
    {
        break;
    }
    else
    {
        continue;
    }
}

