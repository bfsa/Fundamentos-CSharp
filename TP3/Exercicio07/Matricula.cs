namespace Exercicio07;

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
    
    
}