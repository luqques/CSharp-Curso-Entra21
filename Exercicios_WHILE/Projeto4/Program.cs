
using System.Runtime.Serialization;

Console.WriteLine("Insira números positivos, se digitar um negativo, o programa irá para e irá somar os números digitados.");
int numero = 0;
int soma = 0;
while (numero >= 0)
{
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero > 0)
    {
        soma += numero;
    }
}
Console.WriteLine(Convert.ToString(soma));