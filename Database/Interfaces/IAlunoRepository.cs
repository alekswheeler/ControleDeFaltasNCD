namespace ControleDeFaltasNCD.Database.Interfaces;

public interface IAlunoRepository<T>
{
    T RetrieveAlunosByNumero(string numero);

    T RetrieveAlunosByName(string nome);

    T RetrieveAlunosByCodigo(string nome);

    T[] RetrieveAll();

    void Save(T aluno);

    void Delete(T aluno);
}