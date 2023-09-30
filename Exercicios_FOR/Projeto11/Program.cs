try
{
    int n1 = 0;
    int n2 = 1;

    Console.Write($"{n1} {n2} ");
    for (int i = 0; i < 20; i++)
    {
        int f = n1 + n2;
        n1 = n2;
        n2 = f;
        Console.Write($"{f} ");
    }
}
catch (FormatException)
{
    Console.WriteLine("Caractere inválido.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro inesperado.");
}