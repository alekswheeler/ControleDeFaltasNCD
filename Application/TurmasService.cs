using ControleDeFaltasNCD.Domain;

namespace ControleDeFaltasNCD.Application;

public class TurmaService : ITurmaService
{
    ITurmaRepository TurmaRepository;

    public TurmaService(ITurmaRepository turmaRepository)
    {
        this.TurmaRepository = TurmaRepository.turmaRepository;
    }
    public Turma create(string nome, Curso curso, string dias, string horarios, string periodo, Aluno[] alunos, Presenca[] presencas)
    {

        

        var turma = new Turma(nome, curso, dias, horarios, periodo, alunos, presencas);

        Random generator = new Random();
        String r;
        
        do
        {
            r = generator.Next(0, 1000000).ToString("D6");

            try
            {
                this.TurmaRepository.RetrieveTurmasByCodigo(r);
            }catch(Exception err)
            {
                if(err.Message == "Not Found")
                {
                    turma.Codigo = r;

                    this.TurmaRepository.Save(turma);

                    return turma;
                }
            }
        }while(true);
    }

    public void delete(Turma turma)
    {
        this.TurmaRepository.RetrieveAlunosByCodigo();

        this.TurmaRepository.delete(turma);
    }

    public Turma? update(Turma turma)
    {
        throw new NotImplementedException();
    }
}