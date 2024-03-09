namespace Aula03.models;

public class Produto : BaseModel
{
    public string Codigo { get; set; } = "";
    public string Descricao { get; set; } = "";
    public double Preco { get; set; }
}