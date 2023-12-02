// Objeto de Domínio - Presença
public class Presenca
{
    Presenca(DateOnly data, string registro)
    {
        Data = data;
        Registro = registro;
    }
    public DateOnly Data { get; set; }
    public string Registro { get; set; }
}