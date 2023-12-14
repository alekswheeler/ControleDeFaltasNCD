namespace ControleDeFaltasNCD.Application;

using ControleDeFaltasNCD.Database.Interfaces;
using ControleDeFaltasNCD.Domain;

public class CursoService : ICursoService
{
    ICursoRepository CursoRepository;

    public CursoService(ICursoRepository cursoRepository)
    {
        this.CursoRepository = CursoRepository.cursoRepository;
    }
    public Curso create(string nome, string descricao, string cargaHoraria, string codigo)
    {
        var curso = new Curso(nome, descricao, cargaHoraria, codigo);

        this.CursoRepository.save(curso);

        return curso;
    }

    public void delete(Curso curso)
    {
        this.CursoRepository.RetrieveCursosByCodigo(curso.Codigo);

        this.CursoRepository.Delete(curso);
    }

    public Curso? update(Curso curso)
    {
        // Caso o código não seja encontrado, ou o curso não existe, ou a alteração feita tenta trocar o código (que não pode ser alterado).
        try
        {
            this.CursoRepository.RetrieveCursosByCodigo(curso.Codigo);
        }catch(Exception err)
        {
            if(err.Message == "Not Found")
            {
                return null;
            }
        }
        
 
        this.CursoRepository.Save(curso);

        return curso;

    }
}