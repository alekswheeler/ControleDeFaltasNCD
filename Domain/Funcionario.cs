// Objeto de Domínio - Funcionário
public class Funcionario
{
    Funcionario(bool admin, string nome, string email, string senha)
    {
        Admin = admin;
        Nome = nome;
        Email = email;
        Senha = senha;
    }
    public bool Admin { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}