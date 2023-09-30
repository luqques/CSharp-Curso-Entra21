Console.Write("Digite um número inteiro para definir se ele é primo: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = 0;
for (int i = 1; i <= num; i++)
{
    if (num % i == 0 )
    {
        div++;
    }
}
if (div == 2)
{
    Console.WriteLine("O número é primo!");
}
else
{
    Console.WriteLine("O número não é primo");
}