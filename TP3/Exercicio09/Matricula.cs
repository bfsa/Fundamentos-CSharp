namespace Exercicio09;

public class Matricula {
    
    private string nomeDoAluno;
    private string curso;
    private int numeroMatricula;
    private string situacao;
    private string dataInicial;

    public Matricula(string nomeDoAluno, String curso, int numeroMatricula, string situacao, string dataInicial) {
        this.nomeDoAluno = nomeDoAluno;
        this.curso = curso;
        this.numeroMatricula = numeroMatricula;
        this.situacao = situacao;
        this.dataInicial = dataInicial;
    }

    public void Trancar() {
        situacao = "Trancada";
        Console.WriteLine($"## Sua matrícula foi {situacao} ##");
    }

    public void Reativar() {
        situacao = "Ativa";
        Console.WriteLine($"## Sua matrícula foi {situacao} ##");
    }

    public void ExibirInformacoes() {
        Console.WriteLine("===========================");
        Console.WriteLine($"Nome do aluno: {nomeDoAluno}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Numero matricula: {numeroMatricula}");
        Console.WriteLine($"Situacao: {situacao}");
        Console.WriteLine($"Data de Inicio: {dataInicial}");
        Console.WriteLine("===========================");
    }
    
    
    
}