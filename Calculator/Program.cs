using Calculate;
using Calculator;
using System;
Initialization initialization = new Initialization();
SecondCalculating secondcalculating = new SecondCalculating();

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
    Console.WriteLine("Хотите ли вы завершить работу?");
    string choose = Console.ReadLine();
    if (choose == "да")
    {
        Console.WriteLine("Хотите ли вы попробовать другой калькулятор?");
        string chose = Console.ReadLine();
        if (choose == "да")
        {
            Console.WriteLine("Введите число:");
            string Input = Console.ReadLine();
            int num3 = int.Parse(Input);
            Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц, 7 - выход");
            string Math = Console.ReadLine();
            if (Math == "1")
            {
                Console.WriteLine(secondcalculating.Exponentiation2(num3));
            }
            else if (Math == "2")
            {
                Console.WriteLine(secondcalculating.Exponentiation3(num3));
            }
            else if (Math == "3")
            {
                Console.WriteLine(secondcalculating.Root(num3));
            }
            else if (Math == "4")
            {
                Console.WriteLine(secondcalculating.Cos(num3));
            }
            else if (Math == "5")
            {
                Console.WriteLine(secondcalculating.Sin(num3));
            }
            else if (Math == "6")
            {
                Console.WriteLine(secondcalculating.Tan(num3));
            }
            else if (Math == "7")
            {
                break;
            }
        }
        else
        {
            break;
        }
    }
    else
    {
        continue;
    }
}

