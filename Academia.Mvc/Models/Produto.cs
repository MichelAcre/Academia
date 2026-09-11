namespace Academia;

public class Produto
{
    public int Id {get;set;}
    public string Nome {get;set;} = string.Empty; //Ex: Whey, Creatina, Squeeze, Trembolona
    public decimal Preco {get;set;}
    public int Estoque {get;set;}
}
