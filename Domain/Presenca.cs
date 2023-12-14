// Objeto de Domínio - Presença
namespace ControleDeFaltasNCD.Domain;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonIgnoreExtraElements]
public class Presenca
{
    public Presenca(DateOnly data, string registro, Aluno aluno)
    {
        Data = data;
        Registro = registro;
        Aluno = aluno;
    }

    public ObjectId Id { get; set; }
    public DateOnly Data { get; set; }
    public string Registro { get; set; }
    public Aluno Aluno { get; set; }
}