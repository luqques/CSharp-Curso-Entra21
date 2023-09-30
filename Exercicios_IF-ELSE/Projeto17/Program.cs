Console.Write(" Escreva um número para ser convertido para metros ou centímetros:");
decimal numero = Convert.ToDecimal(Console.ReadLine());

Console.Write("Você digitou metros ou centimetros? ");
string unidadeMedida = Console.ReadLine();

switch (unidadeMedida)
{
    case "metros":
        Console.WriteLine(" 1 meter");
        break;
    default:
        Console.WriteLine(" meters");
        break;
}
