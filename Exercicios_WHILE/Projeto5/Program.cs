int i = Convert.ToInt32(Console.ReadLine());
int sum = i;
while (i > 1)
{
    sum *= (i - 1);
    i--;
}

Console.WriteLine(sum);