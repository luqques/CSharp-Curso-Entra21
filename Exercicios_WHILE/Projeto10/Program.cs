
Random rnd = new Random();
int numeroAleatorio = rnd.Next(1, 100);

int numeroChute = 0;
do
{
    Console.Write("Digite um número: ");
    numeroChute = Convert.ToInt32(Console.ReadLine());

    if (numeroChute == numeroAleatorio)
    {
        break;
    }
    else
    {
        if (numeroChute > numeroAleatorio)
        {
            Console.WriteLine("O número digitado é maior que o número aleatório. Tente novamente!");
            Console.WriteLine();
        }
        else if (numeroChute < numeroAleatorio)
        {
            Console.WriteLine("O número digitado é menor que o número aleatório. Tente novamente!");
            Console.WriteLine();
        }
    }
} while (true);
Console.WriteLine("Acertou!!");