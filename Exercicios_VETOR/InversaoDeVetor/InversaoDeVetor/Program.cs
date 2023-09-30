//Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor.

Console.Write("Digite o tamanho do vetor: ");
int tamanhoVetor = Convert.ToInt32(Console.ReadLine());

int[] vetor = new int[tamanhoVetor];

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("Digite um número: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Reverse(vetor);

Console.Write("Vetor invertido: ");
foreach (int i in vetor)
{
    Console.Write($"{i} ");
}
