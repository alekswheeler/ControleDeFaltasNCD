namespace ControleDeFaltasNCD.Application;
using ControleDeFaltasNCD.Domain;

public interface IAlunoService
{
    Aluno create(string nome, string codigo, string telefone);
    Aluno? update(Aluno aluno);
    void delete(Aluno aluno);
}

