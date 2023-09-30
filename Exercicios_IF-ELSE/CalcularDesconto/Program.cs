Console.WriteLine("Qual o preço do produto?");
double preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O membro é vip?");
bool isVip = (Console.ReadLine().ToLower() == "sim") ? true : false;

preco = (isVip == true) ? preco * 0.8 : preco * 0.9;

Console.WriteLine("O preço com desconto é: R$ " + preco);