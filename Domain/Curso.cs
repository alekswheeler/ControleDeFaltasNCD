// Objeto de Domínio - Curso
public class Curso
{
    Curso(string nome, string descricao, string cargahoraria, string codigo)
    {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargahoraria;
        Codigo = codigo;
    }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string CargaHoraria { get; set; }
    public string Codigo { get; set; }
}