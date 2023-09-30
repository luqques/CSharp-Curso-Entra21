//Exercício 1: Potência
//Implemente uma função recursiva chamada Potencia que recebe dois parâmetros base e expoente e calcula a potência de base elevado a expoente.

//Exercício 2: Soma de Números Inteiros
//Crie uma função recursiva chamada Soma que recebe um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.

//Exercício 3: Fibonacci
//Desenvolva uma função recursiva chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna o n-ésimo termo da sequência de Fibonacci.

//Exercício 4: Contagem Regressiva
//Escreva uma função recursiva chamada ContagemRegressiva que recebe um número inteiro positivo n como parâmetro e exibe uma contagem regressiva de n até 1.

//Exercício 5: Máximo Divisor Comum (MDC)
//Crie uma função recursiva chamada MDC que recebe dois números inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles.

class Program 
{ 
    static int CalcularPotencia(int numeroBase, int expoente)
    {
        if (expoente == 0)
        {
            return numeroBase;
        }
        numeroBase *= numeroBase;
        int numeroInicial = numeroBase / expoente;
        return CalcularPotencia(numeroInicial, expoente - 1);        
    }
    
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite um número base: ");
            int numeroBase = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite um expoente: ");
            int expoente = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nResultado: ");
            Console.WriteLine(CalcularPotencia(numeroBase, expoente));


        }

        catch (FormatException)
        {
            Console.WriteLine("Formato de caractere inválido.");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado. {ex.Message}");
        }
    }


}