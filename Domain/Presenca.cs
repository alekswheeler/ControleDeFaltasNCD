// Objeto de Domínio - Presença
public class Presenca
{
    Presenca(DateOnly data, string registro, Aluno[] alunos)
    {
        Data = data;
        Registro = registro;
        Alunos = alunos;
    }
    public DateOnly Data { get; set; }
    public string Registro { get; set; }
    public Aluno[] Alunos { get; set; }
}