namespace ControleDeFaltasNCD.Application;
using ControleDeFaltasNCD.Domain;

public interface ICursoService
{
    Curso create(string nome, string descricao, string cargaHoraria, string codigo);
    Curso? update(Curso curso);
    void delete(Curso curso);
}