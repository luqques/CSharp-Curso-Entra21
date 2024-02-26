namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 2, 25, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Testando extensão de método para string.";
            Console.WriteLine(s1.Cut(10));
        }
    }

}