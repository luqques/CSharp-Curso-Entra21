using System;

Console.WriteLine("Digite um número positivo:");
int num = Convert.ToInt32(Console.ReadLine());
do
{
    num--;
    Console.WriteLine(num);
} while (num > 0);