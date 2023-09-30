
Console.WriteLine("Digite o preço:");
double price = Convert.ToDouble(Console.ReadLine());
price = price * 0.9;
if (price >= 100)
{
    Console.WriteLine(price);
}