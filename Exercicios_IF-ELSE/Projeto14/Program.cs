Console.Write("Qual seu saldo na conta? ");
int saldo = Convert.ToInt32(Console.ReadLine());

Console.Write("Quanto você deseja sacar? ");
int valor = Convert.ToInt32(Console.ReadLine());

if  (saldo < valor)
{
    Console.WriteLine("Saldo insuficiente.");
}
else
{
    Console.WriteLine("Saque autorizado.");
}