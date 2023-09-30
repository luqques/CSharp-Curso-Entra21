using System;

Console.Write("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());
string numeroString = Convert.ToString(numero);

String substring;

int soma = 0;
string somaString = "";

int numeroLength = numeroString.Length;
int i = 0;

do
{
    substring = numeroString.Substring(i, 1);
    Console.WriteLine(substring);
   
    soma += Convert.ToInt32(substring);

    if (i >= 1)
    {
        somaString += $" + {substring}";
    }
    else
    {
        somaString = $"{substring}";
    }

    if (numeroLength == (i + 1))
    {
        break;
    }

    i++;
} while (true);

somaString += " = " + Convert.ToString(soma);
Console.WriteLine(somaString);