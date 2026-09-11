namespace Academia;

public class Aluno
{
        public int Id {get; set;}
    public string Nome {get; set;} = string.Empty; // Nome do plano, string.Empty significa valor vazio
    public DateTime DataNascimento {get;set;}
    public string? UserId {get;set;}
    public List<Matricula>? Matriculas {get;set;} // Lista de matriculas associadas ao aluno
    public List<AvaliacaoFisica>? Avaliacoes {get;set;} // Lista de Avaliações associadas ao aluno
    public List<Inscricao>? Inscricoes {get;set;} // Lista de inscrições associadas ao aluno



}
