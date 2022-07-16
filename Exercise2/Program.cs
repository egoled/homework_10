﻿// Задача 2: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

int RecursiveAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else  
    {
        if (n==0)
        {
            return RecursiveAkkerman(m - 1, 1);
        }
        else
        {
            return RecursiveAkkerman(m - 1, RecursiveAkkerman(m, n - 1));
        }
    }
}


int Prompt (string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    int M = Prompt("Введите первое число функции Аккермана");
    int N = Prompt("Введите второе число функции Аккермана");
    System.Console.WriteLine( RecursiveAkkerman(M, N));

}



Solve();