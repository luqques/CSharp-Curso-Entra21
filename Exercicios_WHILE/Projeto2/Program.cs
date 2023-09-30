Random rnd = new Random();
int num = rnd.Next(1, 100);

bool acertou = false;
int chute = 0;

Console.WriteLine($"O número certo é: {num}");

while (acertou == false)
{
    Console.WriteLine("Digite um número de 1 a 100");
    chute = Convert.ToInt32(Console.ReadLine());
    acertou = chute == num;
}
Console.WriteLine("Acertou!!");
