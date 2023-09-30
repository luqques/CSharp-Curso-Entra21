//Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.

using System.Security.AccessControl;

Console.Write("Digite o tamanho da lista: ");
int tamanhoVetor = Convert.ToInt32(Console.ReadLine());
int[] vetor = new int[tamanhoVetor];

for (int i = 0; i < tamanhoVetor; i++)
{
    Console.Write("Digite o número: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Qual valor deseja que seja contado? ");
int numero = Convert.ToInt32(Console.ReadLine());

int contador = 0;
foreach (int i in vetor)
{
    if (i == numero)
    {
        contador++;
    }
}
Console.WriteLine($"\nO número {numero} aparece {contador} vezes no vetor.");