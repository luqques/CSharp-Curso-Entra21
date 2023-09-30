//Matriz Transposta: Desenvolva um programa que lê uma matriz (3x3) e cria sua matriz transposta, onde as linhas se tornam colunas e vice-versa.

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
        int[,] matriz2 = new int[3, 3];

        matriz1 = RetornarMatriz();
        Console.WriteLine("Matirz 1:");
        MostrarMatriz(matriz1);

        //matriz2
        for (int linha = 0; linha < matriz2.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz2.GetLength(1); coluna++)
            {
                matriz2[linha, coluna] = matriz1[coluna, linha];
            }
        }
        
        Console.WriteLine("Matirz 2:");
        MostrarMatriz(matriz2);

    }
}