try
{
    Console.Write("Digite um número para realizar a tabuada: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int resultado = 0;
    
    for (int i = 0; i <= 10; i++)
    {
        resultado = num * i;
        Console.WriteLine($"{num} * {i} = {resultado}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Caractere inválido. Tente novamente.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro inesperado.");
}
