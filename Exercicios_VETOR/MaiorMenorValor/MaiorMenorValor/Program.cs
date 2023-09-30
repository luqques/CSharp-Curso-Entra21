//Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.

Console.Write("Digite o tamanho do vetor: ");
int tamanhoVetor = Convert.ToInt32(Console.ReadLine());

int[] listaNumeros = new int[tamanhoVetor];

Console.WriteLine("Digite os números da lista:");
for (int i = 0; i < listaNumeros.Length; i++)
{
    listaNumeros[i] = Convert.ToInt32(Console.ReadLine());
}

int maiorNumero = listaNumeros[0];
int menorNumero = listaNumeros[0];
foreach (int i in listaNumeros)
{ 
    if (i > maiorNumero)
    {
        maiorNumero = i;
    }
    else if (i < menorNumero)
    {
        menorNumero = i;
    }
}
Console.WriteLine($"Maior número da lista: {maiorNumero}");
Console.WriteLine($"Menor número da lista: {menorNumero}");