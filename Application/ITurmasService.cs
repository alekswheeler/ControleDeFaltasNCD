namespace ControleDeFaltasNCD.Application;
using ControleDeFaltasNCD.Domain;

public interface ITurmaService
{
    Turma create(string nome, Curso curso, string dias, string horarios, string periodo, Aluno[] alunos, Presenca[] presencas);
    Turma? update(Turma turma);
    void delete(Turma turma);
}