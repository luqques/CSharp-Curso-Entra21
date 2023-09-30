try
{
    int par = 0;
    int impar = 0;
    for (int i = 0; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            par++;
        }
        else
        {
            impar++;
        }
    }
    Console.WriteLine($"{par} números pares e {impar} números ímpares.");
}
catch (FormatException)
{
    Console.WriteLine("Caractere inválido.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro desconhecido.");
}