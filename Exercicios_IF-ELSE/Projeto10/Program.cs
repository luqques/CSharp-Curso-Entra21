Console.Write("Digite seu nome: ");
string nome = Convert.ToString(Console.ReadLine());

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if  (idade <= 12)
{
    Console.WriteLine("Bem vindo, " + nome + "!");
}
else if (idade > 19)
{
    Console.WriteLine("Olá, Sr. " + nome + "!");
}
else
{
    Console.WriteLine("Olá, " + nome + "!");
}