// Objeto de Domínio - Funcionário
namespace ControleDeFaltasNCD.Domain;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class Funcionario
{
    Funcionario(bool admin, string nome, string email, string senha)
    {
        Admin = admin;
        Nome = nome;
        Email = email;
        Senha = senha;
    }

    public ObjectId Id { get; set; }
    public bool Admin { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}