using ControleDeFaltasNCD.Database.Interfaces;
using ControleDeFaltasNCD.Domain;

namespace ControleDeFaltasNCD.Database.Implementations;

public class AlunoRepository : IAlunoRepository<Aluno>
{
    private readonly AlunosDBContext AlunoDB;

    public AlunoRepository()
    {
        AlunoDB = AlunosDBContext.Create(DatabaseConnectionService.GetDatabase(ConnectionSettings.DBNAME, ConnectionSettings.CONNECTIONURI));
    }

    public void Delete(Aluno aluno)
    {
        AlunoDB.Remove(aluno);
        AlunoDB.SaveChanges();
    }

    public Aluno[] RetrieveAll()
    {
        return AlunoDB.Alunos.ToArray();
    }

    public Aluno RetrieveAlunosByName(string nome)
    {
        return AlunoDB.Alunos.FirstOrDefault(a => a.Nome == nome) ?? throw new Exception("Not Found");
    }

    public Aluno RetrieveAlunosByNumero(string numero)
    {
        return AlunoDB.Alunos.FirstOrDefault(a => a.Numero == numero) ?? throw new Exception("Not Found");
    }

    public void Save(Aluno aluno)
    {
        AlunoDB.Alunos.Add(aluno);
        AlunoDB.SaveChanges();
    }
}