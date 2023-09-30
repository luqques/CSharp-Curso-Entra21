
Console.Write("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
int aux = 1;
for (int i = 1; i <= num; i++)
{
    aux *= 2;
    Console.WriteLine($"2^{i} = {aux}");
}
