using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            do
            {
                int exercicio = SelecionarExercicio();
                Console.Clear();

                switch (exercicio)
                {
                    case 1: Somar(); break;
                    case 2: Fatorial(); break;
                    case 3: NumeroPrimo(); break;
                    case 4: MaiorNumero(); break;
                    case 5: InverterString(); break;
                    case 6: Media(); break;
                    case 7: VerificarStringPalindromo(); break;
                    case 8: Fahrenheit(); break;
                    case 9: CincoCaracteres(); break;
                    case 10: CalcularMaximoDivisorComum(); break;
                    case 11: RetornarListaNumerosPares(); break;
                    case 12: RetornarQuantasVezesApareceNaLista(); break;
                    case 13: ConverterMaiusculasMinusculas(); break;
                    case 14: CalcularFibonacci(); break;
                    case 15: DeterminarNumero(); break;
                    default: throw new Exception("Valor inválido.");
                }

                Console.WriteLine("\nDeseja escolher novamente? \n1. Sim \n2. Não");
                bool resposta = Convert.ToInt32(Console.ReadLine()) == 1;
                if (resposta == false)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
                
            } while (true);

        }

        catch (FormatException)
        {

        }

        catch (Exception ex)
        {
            Console.WriteLine($"\nErro inesperado. {ex.Message}");
        }

    }
    
    static int SelecionarExercicio()
    {
        Console.WriteLine("Escolha uma dos exercícios:\n");
        Console.WriteLine("1.Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.");
        Console.WriteLine("2.Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.");
        Console.WriteLine("3.Desenvolva uma função que verifique se um número é primo ou não.");
        Console.WriteLine("4.Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.");
        Console.WriteLine("5.Crie uma função que inverta uma string passada como parâmetro(sem usar funções de inversão embutidas).");
        Console.WriteLine("6.Escreva uma função que calcule a média de uma lista de números reais.");
        Console.WriteLine("7.Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.");
        Console.WriteLine("8.Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.");
        Console.WriteLine("9.Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.");
        Console.WriteLine("10.Escreva uma função que calcule o máximo divisor comum(MDC) entre dois números inteiros.");
        Console.WriteLine("11.Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.");
        Console.WriteLine("12.Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.");
        Console.WriteLine("13.Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.");
        Console.WriteLine("14.Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.");
        Console.WriteLine("15.Desenvolva uma função que determine se um número é positivo, negativo ou zero.");

        int exercicio = Convert.ToInt32(Console.ReadLine());
        return exercicio;
    }

    //1
    static void Somar()
    {
        try
        {
            static int CalcularSoma(int n1, int n2)
            {
                int soma = n1 + n2;
                return soma;
            }

            Console.WriteLine("1.Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.\n");
            Console.Write("Digite o primeiro número a ser somado: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o segundo número a ser somado: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int soma = CalcularSoma(n1, n2);

            Console.WriteLine($"\nTotal = {soma}");
        }

        catch (FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //2
    static void Fatorial()
    {
        try
        {
            static int CalcularFatorial(int numero)
            {
                int fatorialResultado = numero;

                for (int i = numero - 1; i > 1; i--)
                {
                    fatorialResultado *= i;
                }
                return fatorialResultado;
            }

            Console.WriteLine("2.Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.\n");
            Console.Write("Digite um número para ser calculado seu fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int fatorialResultado = CalcularFatorial(numero);
            Console.WriteLine($"{numero}! = {fatorialResultado}");
        }

        catch (FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //3
    static void NumeroPrimo()
    {
        try
        {
            static bool VerificarNumeroPrimo(int numero)
            {
                bool isPrimo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        isPrimo = false;
                    }
                }

                return isPrimo;
            }

            Console.WriteLine("3.Desenvolva uma função que verifique se um número é primo ou não.\n");
            Console.Write("Digite um número para verificar se ele é primo ou não: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool isPrimo = VerificarNumeroPrimo(numero);
            if (isPrimo)
            {
                Console.WriteLine($"O número {numero} É primo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO é primo.");
            }
        }

        catch (FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //4
    static void MaiorNumero()
    {
        try
        {
            static int VerificarMaiorNumero(int[] listaInteiros)
            {
                int maiorNumero = listaInteiros[0];

                foreach (int i in listaInteiros)
                {
                    if (i > maiorNumero)
                    {
                        maiorNumero = i;
                    }
                }
                return maiorNumero;
            }

            Console.WriteLine("4.Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.\n");
            Console.WriteLine("Qual será o tamanho da sua lista de números inteiros?");
            int quantidadeLista = Convert.ToInt32(Console.ReadLine());

            int[] listaInteiros = new int[quantidadeLista];

            Console.WriteLine("\nDigite os números da lista: ");
            for (int i = 0; i < listaInteiros.Length; i++)
            {
                listaInteiros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maiorNumero = VerificarMaiorNumero(listaInteiros);
            Console.WriteLine($"\nO maior número da lista é o {maiorNumero}");
        }

        catch(FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //5
    static void InverterString()
    {
        try
        {
            static char[] RetornarStringInvertida(string frase)
            {
                int tamanhoString = frase.Length;
                char[] letrasInvertido = new char[tamanhoString];

                int j = 0;
                for (int i = frase.Length - 1; i >= 0; i--)
                {
                    letrasInvertido[j] = frase[i];
                    j += 1;
                }

                return letrasInvertido;
            }

            Console.WriteLine("5.Crie uma função que inverta uma string passada como parâmetro(sem usar funções de inversão embutidas).\n");
            Console.Write("Escreva uma frase para ser invertida: ");
            string frase = Console.ReadLine();
            char[] letrasInvertido = RetornarStringInvertida(frase);

            Console.Write($"\nFrase invertida: ");
            foreach (char letra in letrasInvertido )
            {
                Console.Write(letra);
            }
            Console.WriteLine();
        }

        catch(FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //6
    static void Media()
    {
        try
        {
            static double CalcularMedia(int quantidadeNumeros)
            {
                double media = 0;

                Console.WriteLine("Insira os números:");

                int[] numeros = new int[quantidadeNumeros];
                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (int i in numeros)
                {
                    media += i;
                }
                media /= numeros.Length;
                return media;
            }

            Console.WriteLine("6.Escreva uma função que calcule a média de uma lista de números reais.\n");
            Console.Write("Qual o tamanho da sua lista de números? ");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

            double media = CalcularMedia(quantidadeNumeros);
            Console.WriteLine($"\nA média é {media}");

        }

        catch(FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }

    }

    //7
    static void VerificarStringPalindromo()
    {
        try
        {
            static bool RetornarPalindromo(string frase)
            {
                bool isPalindromo = false;
                char[] fraseInvertida = new char[frase.Length];
                char[] fraseArray = new char[frase.Length];

                int j = 0;
                for (int i = frase.Length - 1; i >= 0; i--)
                {
                    fraseInvertida[j] = frase[i];
                    j += 1;
                }

                string fraseInvertidaString = new string(fraseInvertida);

                if (fraseInvertidaString.Equals(frase))
                {
                    isPalindromo = true;
                }
                else
                {
                    isPalindromo = false;
                }

                return isPalindromo;
            }
            
            Console.WriteLine("7.Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.\n");
            Console.Write("Digite a sua frase: ");
            string frase = Console.ReadLine();

            bool isPalindromo = RetornarPalindromo(frase);

            if (isPalindromo)
            {
                Console.WriteLine("A frase é palíndromo.");
            }
            else
            {
                Console.WriteLine("A frase NÃO é palíndromo.");
            }

        }

        catch(FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //8
    static void Fahrenheit()
    {
        try
        {
            static int RetornarFahrenheit(int grausCelsius)
            {
                int grausFahrenheit = (grausCelsius * 9 / 5) + 32;
                return grausFahrenheit;
            }

            Console.WriteLine("8.Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.\n");
            Console.Write("Informe os graus Celcius: ");
            int grausCelsius = Convert.ToInt32(Console.ReadLine());

            int grausFahrenheit = RetornarFahrenheit(grausCelsius);
            Console.WriteLine($"\n{grausCelsius}º graus Celcius é igual a {grausFahrenheit}º graus Fahrenheit");
        }

        catch (FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //9
    static void CincoCaracteres()
    {
        try
        {
            static int RetornarQuantidadeDeStringsComMaisDeCincoCaracteres(string[] frases)
            {
                int quantidadeStringsComMaisDeCincoCaracteres = 0;

                foreach (string frase in frases)
                {
                    int quantidadeCaracteres = frase.Length;
                    if (quantidadeCaracteres > 5)
                    {
                        quantidadeStringsComMaisDeCincoCaracteres += 1;
                    }
                }
                return quantidadeStringsComMaisDeCincoCaracteres;
            }

            static string[] RetornarQuantidadeStrings(int quantidadeStrings)
            {
                string[] frases = new string[quantidadeStrings];
                for (int i = 0; i < frases.Length; i++)
                {
                    Console.Write("Digite uma frase: ");
                    frases[i] = Console.ReadLine();
                }

                return frases;
            }

            Console.WriteLine("9.Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.\n");
            Console.Write("Digite a quantidade de frases que deseja escrever: ");
            int quantidadeStrings = Convert.ToInt32(Console.ReadLine());

            string[] frases = RetornarQuantidadeStrings(quantidadeStrings);

            int quantidadeStringsComMaisDeCincoCaracteres = RetornarQuantidadeDeStringsComMaisDeCincoCaracteres(frases);
            Console.WriteLine(quantidadeStringsComMaisDeCincoCaracteres);
        }

        catch (FormatException)
        {
            Console.WriteLine("\nERRO: Caractere inválido.");
        }
    }

    //10
    static void CalcularMaximoDivisorComum()
    {
       
    }

    //11
    static void RetornarListaNumerosPares()
    {
        
    }

    //12
    static void RetornarQuantasVezesApareceNaLista()
    {
    
    }

    //13
    static void ConverterMaiusculasMinusculas()
    {

    }

    //14
    static void CalcularFibonacci()
    {
        
    }

    //15
    static void DeterminarNumero()
    {
    
    }
}