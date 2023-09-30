
try
{
    Console.Write("Digite um número: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = num;

    for (int i = num - 1; i > 1; i--)
    {
        result *= i;        
    }
    Console.WriteLine($"{num}! = {result}");
}
catch (FormatException)
{
    Console.WriteLine("Formato de caractere inválido, tente novamente!");
}
catch (Exception ex)
{
    Console.WriteLine("Erro inesperado.");
}