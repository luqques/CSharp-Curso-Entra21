//Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.

int soma = 0;

int[] listaNumeros = new int[5];

Console.WriteLine("Digite 5 números para realizar uma soma e uma média:");
for (int i = 0; i < listaNumeros.Length; i++)
{
    listaNumeros[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int i in listaNumeros)
{
    soma += i;
}
double media = soma / 5;

Console.Write($"Soma dos elementos: {soma}\n");
Console.Write($"Média dos elementos: {media}\n");