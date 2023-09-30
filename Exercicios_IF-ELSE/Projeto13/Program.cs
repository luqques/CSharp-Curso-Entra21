
Console.WriteLine("Digite 3 números inteiros:");

int n1 = Convert.ToInt32(Console.ReadLine());  
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2 || n2 == n3 || n1 == n3)
{
    Console.WriteLine("Pelo menos dois dos números digitados são iguais.");
}
else
{
    Console.WriteLine("Nenhum dos números são iguais entre si.");
}