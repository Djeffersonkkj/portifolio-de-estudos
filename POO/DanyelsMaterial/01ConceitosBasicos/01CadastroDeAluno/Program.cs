Aluno aluno1 = new Aluno();
aluno1.Nome = "Geremias Vasconcelos";
aluno1.Idade = 2;
aluno1.Turma = "156-B";

Aluno aluno2 = new Aluno();
aluno2.Nome = "Diogenes Pinkman";
aluno2.Idade = 4;
aluno2.Turma = "157-a";

string ApresentacaoAluno1 = aluno1.ApresentarSe();
Console.WriteLine(ApresentacaoAluno1);
string ApresentacaoAluno2 = aluno2.ApresentarSe();
Console.WriteLine(ApresentacaoAluno2);


