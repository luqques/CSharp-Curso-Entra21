
Console.WriteLine("Deseja café?");

string resposta = Console.ReadLine();
resposta = resposta.ToLower();

if (resposta.Equals("sim"))
{
    Console.WriteLine("Deseja açúcar?");
    string respostaAcucar = Console.ReadLine();
    respostaAcucar = respostaAcucar.ToLower();

    if (respostaAcucar.Equals("sim"))
    {
        Console.WriteLine("Aqui está o seu café preto com açúcar.");
    }
    else if (respostaAcucar.Equals("não"))
    {
        Console.WriteLine("Aqui está o seu café preto.");
    }
}
else if (resposta.Equals("não"))
{
    Console.WriteLine("Ok.");
}