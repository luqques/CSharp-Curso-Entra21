
Console.WriteLine("Insira as notas para calcular a média:");
double nota = 0;
double media = 0;
int contador = 0;
double notaTotal = 0;
do
{
    nota = Convert.ToInt32(Console.ReadLine());
    
    if (nota < 0)
    {        
        notaTotal = notaTotal / contador;
    }
    else
    {
        notaTotal += nota;
        contador++;
    }
} while (nota >= 0);

Console.WriteLine(notaTotal);