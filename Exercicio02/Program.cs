using System;
using static Exercicio01.Generics.Alunos;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Informe um codigo para efetuar a pesquisa de alunos");
            Console.WriteLine("O padrão de codigos é A060000, subistitua os ultimos numeros zero para procurar na listagem");
            var codigo = Console.ReadLine();

            var aluno = RetornaAlunoLINQ(codigo);
            if (aluno != null)
            {
                Console.WriteLine("A pesquisa retornou o seguinte aluno");
                Console.WriteLine(aluno);
            }
            else
            {
                Console.WriteLine("A pesquisa não retornou resultados");
            }
        }
    }
}
