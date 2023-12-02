// Objeto de Domínio - Aluno
public class Aluno
{
    Aluno(string nome, string numero, string codigo)
    {
        Nome = nome;
        Numero = numero;
        Codigo = codigo;
    }

    public string Nome { get; set; }
    public string Numero { get; set; } // número = telefone
    public string Codigo { get; set; }
}