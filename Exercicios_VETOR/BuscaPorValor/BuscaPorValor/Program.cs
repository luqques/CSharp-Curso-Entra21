//Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar.
//A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.

int[] lista = { 3, 7, 12, 16, 23, 30, 35 };

Console.Write("Adivinhe um valor presente na lista: ");

while (true)
{
    bool acertou = false;
    int numero = Convert.ToInt32(Console.ReadLine());
    foreach (int i in lista)
    {       
        if (i == numero)
        {
            Console.WriteLine("Acertou!");
            acertou = true;
            break;            
        }
    }
    if (acertou == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Tente novamente");
    }
}

