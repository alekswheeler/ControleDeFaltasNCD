namespace ControleDeFaltasNCD.Application;
using ControleDeFaltasNCD.Domain;

public interface IUsuarioService
{
    Funcionario create(bool admin, string nome, string email, string senha);
    Funcionario? update(Funcionario funcionario);
    void delete(Funcionario funcionario);
}