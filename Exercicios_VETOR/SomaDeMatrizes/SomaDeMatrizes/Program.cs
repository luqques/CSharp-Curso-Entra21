//Soma de Matrizes: Crie um programa que lê duas matrizes (mesmo tamanho) e realiza a soma entre elas, armazenando o resultado em uma terceira matriz.

using System.Net.NetworkInformation;

class Program
{
    static int[,] RetornarMatriz()
    {
        int[,] matriz = new int[2, 3];
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
        int[,] matriz1 = new int[2, 3];
        int[,] matriz2 = new int[2, 3];
        int[,] matriz3 = new int[2, 3];

        matriz1 = RetornarMatriz();
        matriz2 = RetornarMatriz();

        for (int linha = 0; linha < matriz3.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz1.GetLength(1); coluna++)
            {
                matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
            }
        }

        MostrarMatriz(matriz1);
        Console.WriteLine("\n+\n");
        MostrarMatriz(matriz2);
        Console.WriteLine("\n=\n");
        MostrarMatriz(matriz3);        

    }
}