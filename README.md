Atividade Semana 02 - Generics, Injeção de Dependência e Entity Framework
------------------------------------------------------------------------------------------------

1) Crie uma Solution chamada "AtivSem02", com um Projeto Console

2) Neste projeto crie um arquivo de classe "Generics.cs"

2.1) Crie uma classe publica "Alunos" com 3 atributos publicos 

2.2) Crie um método estático que retorna uma Generic do tipo List<>, com 10 alunos incluidos

2.3) Crie um método que faz pesquisa nessa Generic via LINQ, retornando um aluno a partir de um parametro informado (ex. um código). DEVE FUNCIONAR.

2.4) Exiba a pesquisa na aplicação Console

3) Neste projeto crie um arquivo de classe "InjDep" 

3.1) Crie uma Interface "IBancos" com dois métodos, um deles retornando DOUBLE e outro recebendo DOUBLE como parametro.

3.2) Crie 3 classes que implementem a interface "IBancos"

3.3) Crie uma classe de Transferencias Bancárias, com o método TRANFERIR. Este metodo tem a seguinte lógica: Banco 01 entrega o valor e Banco 02 recebe o valor. BASTA A ESTRUTURA ESTAR MONTADA.

3.4) A classe de Transferencia Bancária deve receber uma injeção de dependecia via construtor dos dois bancos envolvidos

3.5) Na aplicação Console, realize a transferencia bancaria 

[DESAFIO OPCIONAL - Pesquise MODEL FIRST / DATABASE FIRST para Fazer]

---------------

4) Na solução que já existe, inclua um projeto Windows/Web (qualquer um)

4.1) Neste projeto, faça referencia ao Entity Framework

4.2) Crie um diagrama MODEL FIRST com uma classe qualquer

4.3) Gere o script sql para criação desta entidade no Banco de Dados

4.4) Crie um diagrama DATABASE FIRST, acessando qualquer Banco de Dados, trazendo uma tabela e gerando sua  classe

---------------

5) Publique seu projeto no GitHub, colocando-o em um repositório Publico