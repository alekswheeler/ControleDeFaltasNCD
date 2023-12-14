//Objeto de Domínio - Turma
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ControleDeFaltasNCD.Domain;

[BsonIgnoreExtraElements]
public class Turma
{
    Turma(string nome, string curso, string dias, string horarios, string periodo, Aluno[] alunos, Presenca[] presencas)
    {
        Nome = nome;
        Curso = curso;
        Dias = dias;
        Horarios = horarios;
        Periodo = periodo;
        Alunos = alunos;
        Presencas = presencas;
    }

    public ObjectId Id { get; set; }
    public string Nome { get; set; }
    public string Curso { get; set; }
    public string Dias { get; set; }
    public string Horarios { get; set; }
    public string Periodo { get; set; }
    public Aluno[] Alunos { get; set; }
    public Presenca[] Presencas { get; set; }

}