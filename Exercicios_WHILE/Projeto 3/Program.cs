int resultado = 0;
while (true)
{
    Console.Write("Digite o primeiro número: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a operação que deseja realizar: ");
    char operacao = Convert.ToChar(Console.ReadLine());

    switch (operacao)
    {
        case '-':
            resultado = n1 - n2;
            break;
        case '+':
            resultado = n1 + n2;
            break;
        case '*':
            resultado = n1 * n2;
            break;
        case '/':
            resultado = n1 / n2;
            break;
        default:
            resultado = n1 - n2;
            break;
    }
    Console.WriteLine($"Resultado: {resultado}");

    Console.WriteLine("Deseja sair da operação?");
    string resposta = (Console.ReadLine());

    if (resposta.ToLower().Equals("sim"))
    {
        break;
    }
}