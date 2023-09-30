//Maior Elemento por Linha: Implemente um programa que encontra e exibe o maior elemento em cada linha de uma matriz.
class Program
{
    static int[,] RetornarMatriz()
    {
        int[,] matriz = new int[3, 3];
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                Console.WriteLine($"Digite um número para a linha {linha}, coluna {coluna}.");
                matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return matriz;
    }

    static void MostrarMatriz(int[,] matriz)
    {
        Console.WriteLine();
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                Console.Write($"{matriz[linha, coluna]} ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int[,] matriz1 = new int[3, 3];       

        matriz1 = RetornarMatriz();
        Console.WriteLine("Matirz:");
        MostrarMatriz(matriz1);

        int maiorNumero = 0;
        string maioresNumeros = "";
        int numAnterior = 0;
        for (int linha = 0; linha < matriz1.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz1.GetLength(1); coluna++)
            {
                if (matriz1[linha, coluna] > numAnterior)
                {
                    maiorNumero = matriz1[linha, coluna];
                }
                numAnterior = matriz1[linha, coluna];
            }
            maioresNumeros += $"{maiorNumero} ";
            numAnterior = 0;
        }

        Console.WriteLine($"\nOs maiores números de cada linha são: {maioresNumeros}");

    }
}