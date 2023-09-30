
Console.WriteLine("Digite a idade da pessoa: ");
int idade = Convert.ToInt32(Console.ReadLine());

string fase = (idade <= 12) ? "Criança" : (idade >= 13 && idade <= 19) ? "Adolescente" : (idade >= 20) ? "Adulto" : "";

Console.WriteLine(fase);