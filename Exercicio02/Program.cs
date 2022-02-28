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
                Console.WriteLine("nome: {0}   idade: {1}    Codigo aluno: {2}", aluno.Nome, aluno.Idade, aluno.Codigo);
            }
            else
            {
                Console.WriteLine("A pesquisa não retornou resultados");
            }
            
            Console.WriteLine();
            Console.WriteLine();

            Santander santander = new Santander();
            Itau itau = new Itau();
            Caixa caixa = new Caixa();

            TranferenciaBancaria tranferencia1 = new TranferenciaBancaria(santander, itau);
            tranferencia1.IniciarTranferencia();

            Console.WriteLine();
            Console.WriteLine();

            TranferenciaBancaria tranferencia2 = new TranferenciaBancaria(santander, caixa);
            tranferencia2.IniciarTranferencia();

            Console.WriteLine();
            Console.WriteLine();

            TranferenciaBancaria tranferencia3 = new TranferenciaBancaria(itau, caixa);
            tranferencia3.IniciarTranferencia();

            Console.WriteLine();
            Console.WriteLine();

            TranferenciaBancaria tranferencia4 = new TranferenciaBancaria(itau, santander);
            tranferencia4.IniciarTranferencia();

            Console.WriteLine();
            Console.WriteLine();

            TranferenciaBancaria tranferencia5 = new TranferenciaBancaria(caixa, santander);
            tranferencia5.IniciarTranferencia();

            Console.WriteLine();
            Console.WriteLine();

            TranferenciaBancaria tranferencia6 = new TranferenciaBancaria(caixa, itau);
            tranferencia6.IniciarTranferencia();

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
