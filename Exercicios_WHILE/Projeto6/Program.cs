
Console.Write("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
int resultado = 0;
int contador = 0;
do
{
    resultado = num * contador;
    Console.WriteLine($"{num} * {contador} = {resultado}");
    contador++;
} while (contador <= 10);
