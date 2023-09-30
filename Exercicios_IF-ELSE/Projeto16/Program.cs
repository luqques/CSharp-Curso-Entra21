
Console.WriteLine("Qual operador você deseja para o cálculo?");
char operador = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite dois números para realizar o cálculo");
double n1 = Convert.ToDouble(Console.ReadLine());
double n2 = Convert.ToDouble(Console.ReadLine());

double resultado = 0;

switch (operador)
{
    case '+':
        resultado = n1 + n2;
        break;

    case '-':
        resultado = n1 - n2;
        break;

    case '/':
        resultado = n1 / n2;
        break;

    case '*':
        resultado = n1 * n2;
        break;
}

Console.WriteLine("O resultado é: " + Convert.ToString(resultado));


