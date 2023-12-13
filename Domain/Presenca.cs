// Objeto de Domínio - Presença

using MongoDB.Bson.Serialization.Attributes;
namespace ControleDeFaltasNCD.Domain;

[BsonIgnoreExtraElements]
public class Presenca
{
    public Presenca(DateOnly data, string registro, Aluno aluno)
    {
        Data = data;
        Registro = registro;
        Aluno = aluno;
    }
    public DateOnly Data { get; set; }
    public string Registro { get; set; }
    public Aluno Aluno { get; set; }
}