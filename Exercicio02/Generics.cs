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
                Alunos aluno1 = new Alunos();
                Alunos aluno2 = new Alunos();
                Alunos aluno3 = new Alunos();
                Alunos aluno4 = new Alunos();
                Alunos aluno5 = new Alunos();
                Alunos aluno6 = new Alunos();
                Alunos aluno7 = new Alunos();
                Alunos aluno8 = new Alunos();
                Alunos aluno9 = new Alunos();
                Alunos aluno10 = new Alunos();

                aluno1.Idade = 10;
                aluno1.Nome = "José";
                aluno1.Codigo = "A060001";

                alunosList.Add(aluno1);

                aluno2.Idade = 11;
                aluno2.Nome = "Rodrigo";
                aluno2.Codigo = "A060002";

                alunosList.Add(aluno2);

                aluno3.Idade = 13;
                aluno3.Nome = "Larissa";
                aluno3.Codigo = "A060003";

                alunosList.Add(aluno3);

                aluno4.Idade = 12;
                aluno4.Nome = "Guilherme";
                aluno4.Codigo = "A060004";

                alunosList.Add(aluno4);

                aluno5.Idade = 11;
                aluno5.Nome = "Antonio";
                aluno5.Codigo = "A060005";

                alunosList.Add(aluno5);

                aluno6.Idade = 10;
                aluno6.Nome = "Matheus";
                aluno6.Codigo = "A060006";

                alunosList.Add(aluno6);

                aluno7.Idade = 08;
                aluno7.Nome = "Elaine";
                aluno7.Codigo = "A060007";

                alunosList.Add(aluno7);

                aluno8.Idade = 10;
                aluno8.Nome = "Ana";
                aluno8.Codigo = "A060008";

                alunosList.Add(aluno8);

                aluno9.Idade = 11;
                aluno9.Nome = "Josefina";
                aluno9.Codigo = "A060009";

                alunosList.Add(aluno9);

                aluno10.Idade = 12;
                aluno10.Nome = "Maria";
                aluno10.Codigo = "A060010";

                alunosList.Add(aluno10);
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
