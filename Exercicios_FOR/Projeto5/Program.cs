try
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}
catch (FormatException)
{
    Console.WriteLine("Formato de caractere inválido.");
}
finally
{
    Console.WriteLine("The 'try catch' is finished.");
}