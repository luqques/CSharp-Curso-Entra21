try
{
    int total = 0;
    for (int i = 0; i <= 100; i++)
    {
        total += i;
    }
    Console.WriteLine(total);
}
catch (Exception ex)
{
    Console.WriteLine("Erro");
}
finally
{
    Console.WriteLine("The 'try catch' is finished.");
}