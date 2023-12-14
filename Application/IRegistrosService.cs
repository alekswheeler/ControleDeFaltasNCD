namespace ControleDeFaltasNCD.Application;
using ControleDeFaltasNCD.Domain;

public interface IRegistroService
{
    Presenca create(Aluno aluno, Turma turma, DateOnly data);
    Presenca? update(Presenca presenca);
    void delete(Presenca presenca);
}