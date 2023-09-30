
//Verificação de Matriz Nula: Implemente um programa que verifica se uma matriz é uma matriz nula, ou seja, todos os seus elementos são iguais a zero.
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

        bool isNull = false;
        for (int linha = 0; linha < matriz1.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz1.GetLength(1); coluna++)
            {
                if (matriz1[linha, coluna] <= 0)
                {
                    isNull = true;
                }
                else
                {
                    isNull = false;
                    break;
                }
            }
            if (isNull)
            {
                continue;
            }
            else
            {
                break;
            }
        }

        if (isNull)
        {
            Console.WriteLine("\nA matriz é nula.");
        }
        else
        {
            Console.WriteLine("\nA matriz não é nula.");
        }

    }
}