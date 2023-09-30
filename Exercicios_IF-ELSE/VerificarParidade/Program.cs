
Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

string parImpar = (numero % 2 == 0) ? "Par" : "Ímpar";

Console.WriteLine(parImpar);