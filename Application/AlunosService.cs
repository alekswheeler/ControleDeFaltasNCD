namespace ControleDeFaltasNCD.Application;

using ControleDeFaltasNCD.Database.Interfaces;
using ControleDeFaltasNCD.Domain;

public class AlunoService : IAlunoService
{
    IAlunoRepository AlunoRepository;

    public AlunoService(IAlunoRepository alunoRepository)
    {
        this.AlunoRepository = AlunoRepository.alunoRepository;
    }
    public Aluno create(string nome, string codigo, string telefone)
    {
        var aluno = new Aluno(nome, codigo, telefone);

        this.AlunoRepository.Save(aluno);

        return aluno;
    }

    public void delete(Aluno aluno)
    {
        
        this.AlunoRepository.RetrieveAlunosByCodigo(aluno.Codigo);

        this.AlunoRepository.Delete(aluno);
    }

    public Aluno? update(Aluno aluno)
    {

        // Caso o código não seja encontrado, ou o aluno não existe, ou a alteração feita tenta trocar o código (que não pode ser alterado).
        try
        {
            this.AlunoRepository.RetrieveAlunosByCodigo(aluno.Codigo);
        }catch(Exception err)
        {
            if(err.Message == "Not Found")
            {
                return null;
            }
        }
        
 
        this.AlunoRepository.Save(aluno);

        return aluno;
    }
}


