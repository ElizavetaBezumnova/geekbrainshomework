﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

System.Console.Write("Введите число m:");
int M = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите число n:");
int N = int.Parse(Console.ReadLine()!);

 int Akkerman(int m, int n)
{
    if (m==0)
        return n+1;
    else
        if ((m!=0) && (n==0))
            return Akkerman(m-1,1);
        else
            return Akkerman(m-1,Akkerman(m,n-1));
}

System.Console.WriteLine(Akkerman(M,N));