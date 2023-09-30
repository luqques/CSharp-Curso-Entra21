
namespace POO;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Lucas";
        aluno1.idade = 20;
        Console.WriteLine(aluno1.nome);
        Console.WriteLine(aluno1.idade);
        aluno1.dizerOi();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Tiago";
        aluno2.idade = 25;
        Console.WriteLine(aluno2.nome);
        Console.WriteLine(aluno2.idade);
        aluno2.dizerOi();
        aluno2.dizerOi();
        aluno2.dizerOi();
        aluno2.dizerOi();

    }
}