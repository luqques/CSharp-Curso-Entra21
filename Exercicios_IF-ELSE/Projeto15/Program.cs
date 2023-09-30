
Console.Write("Se identifique: ");
int id = Convert.ToInt32(Console.ReadLine());

Console.Write("Que horas está entrando? ");
int hora = Convert.ToInt32(Console.ReadLine());

if (id == 1234 && hora >= 9 && hora <= 18)
{
    Console.WriteLine("Acesso liberado!");
}
else
{
    Console.WriteLine("Acesso negado.");
}
