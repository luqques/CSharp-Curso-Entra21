try
{
    Console.WriteLine("Digite a altura do triângulo: ");
    int altura = Convert.ToInt32(Console.ReadLine());
    string linha = "";
    for (int i = altura; i >= 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            linha += " ";
        }
        linha += "*";
        Console.WriteLine(linha);
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