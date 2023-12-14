// Objeto de Domínio - Aluno
namespace ControleDeFaltasNCD.Domain;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


[BsonIgnoreExtraElements]
public class Aluno
{
    public Aluno(string nome, string codigo, string numero)
    {
        Nome = nome;
        Numero = numero;
        Codigo = codigo;
    }

    public ObjectId Id { get; set; }

    public string Nome { get; set; }

    public string Numero { get; set; } // número = telefone

    public string Codigo { get; set; }


    public void ImprimeAluno()
    {
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Numero: " + this.Numero);
        Console.WriteLine("Codigo: " + this.Codigo);
    }
}



