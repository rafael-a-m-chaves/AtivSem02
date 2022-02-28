Atividade Semana 02 - Generics, Inje��o de Depend�ncia e Entity Framework
------------------------------------------------------------------------------------------------

1) Crie uma Solution chamada "AtivSem02", com um Projeto Console

2) Neste projeto crie um arquivo de classe "Generics.cs"

2.1) Crie uma classe publica "Alunos" com 3 atributos publicos 

2.2) Crie um m�todo est�tico que retorna uma Generic do tipo List<>, com 10 alunos incluidos

2.3) Crie um m�todo que faz pesquisa nessa Generic via LINQ, retornando um aluno a partir de um parametro informado (ex. um c�digo). DEVE FUNCIONAR.

2.4) Exiba a pesquisa na aplica��o Console

3) Neste projeto crie um arquivo de classe "InjDep" 

3.1) Crie uma Interface "IBancos" com dois m�todos, um deles retornando DOUBLE e outro recebendo DOUBLE como parametro.

3.2) Crie 3 classes que implementem a interface "IBancos"

3.3) Crie uma classe de Transferencias Banc�rias, com o m�todo TRANFERIR. Este metodo tem a seguinte l�gica: Banco 01 entrega o valor e Banco 02 recebe o valor. BASTA A ESTRUTURA ESTAR MONTADA.

3.4) A classe de Transferencia Banc�ria deve receber uma inje��o de dependecia via construtor dos dois bancos envolvidos

3.5) Na aplica��o Console, realize a transferencia bancaria 

[DESAFIO OPCIONAL - Pesquise MODEL FIRST / DATABASE FIRST para Fazer]

---------------

4) Na solu��o que j� existe, inclua um projeto Windows/Web (qualquer um)

4.1) Neste projeto, fa�a referencia ao Entity Framework

4.2) Crie um diagrama MODEL FIRST com uma classe qualquer

4.3) Gere o script sql para cria��o desta entidade no Banco de Dados

4.4) Crie um diagrama DATABASE FIRST, acessando qualquer Banco de Dados, trazendo uma tabela e gerando sua  classe

---------------

5) Publique seu projeto no GitHub, colocando-o em um reposit�rio Publico