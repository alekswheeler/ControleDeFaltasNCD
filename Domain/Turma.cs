//Objeto de Domínio - Turma
public class Turma
{
    Turma(string nome, string curso, string dias, string horarios, string periodo)
    {
        Nome = nome;
        Curso = curso;
        Dias = dias;
        Horarios = horarios;
        Periodo = periodo;
    }
    public string Nome { get; set; }
    public string Curso { get; set; }
    public string Dias { get; set; }
    public string Horarios { get; set; }
    public string Periodo { get; set; }
}