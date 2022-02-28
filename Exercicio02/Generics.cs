using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Generics
    {
        public class Alunos
        {
            public int Idade { get; set; }
            public string Nome { get; set; }
            public string Codigo { get; set; }

            public static List<Alunos> RetornaAlunosList()
            {
                List<Alunos> alunosList = new List<Alunos>();
                Alunos aluno = new Alunos();

                aluno.Idade = 10;
                aluno.Nome = "José";
                aluno.Codigo = "A060001";

                alunosList.Add(aluno);

                aluno.Idade = 11;
                aluno.Nome = "Rodrigo";
                aluno.Codigo = "A060002";

                alunosList.Add(aluno);

                aluno.Idade = 13;
                aluno.Nome = "Larissa";
                aluno.Codigo = "A060003";

                alunosList.Add(aluno);

                aluno.Idade = 12;
                aluno.Nome = "Guilherme";
                aluno.Codigo = "A060004";

                alunosList.Add(aluno);

                aluno.Idade = 11;
                aluno.Nome = "Antonio";
                aluno.Codigo = "A060005";

                alunosList.Add(aluno);

                aluno.Idade = 10;
                aluno.Nome = "Matheus";
                aluno.Codigo = "A060006";

                alunosList.Add(aluno);

                aluno.Idade = 08;
                aluno.Nome = "Elaine";
                aluno.Codigo = "A060007";

                alunosList.Add(aluno);

                aluno.Idade = 10;
                aluno.Nome = "Ana";
                aluno.Codigo = "A060008";

                alunosList.Add(aluno);

                aluno.Idade = 11;
                aluno.Nome = "Josefina";
                aluno.Codigo = "A060009";

                alunosList.Add(aluno);

                aluno.Idade = 12;
                aluno.Nome = "Maria";
                aluno.Codigo = "A060010";

                alunosList.Add(aluno);

                return alunosList;
            }

            public static Alunos RetornaAlunoLINQ(string codigo)
            {
                Alunos aluno = new Alunos();
                
                try
                {
                    var listAlunos = RetornaAlunosList();
                    aluno = listAlunos.Find(r => r.Codigo == codigo); 
                }
                catch
                {
                    Console.WriteLine("Não foi possivel acessar a lista de alunos...");
                }
                return aluno;
            }
        }

        
}

}
