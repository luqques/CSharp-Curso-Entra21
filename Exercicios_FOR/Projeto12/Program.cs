try
{
    for (int i = 0; (i < 2); i++)
    {
        Console.Write("Digite um número para saber se é primo ou não: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            i = 0;
            Console.WriteLine("Seu número é par!");
        }
    }
    Console.WriteLine("Seu número é ímpar!");

}
catch (FormatException)
{
    Console.WriteLine("Caractere inválido.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro inesperado.");
}