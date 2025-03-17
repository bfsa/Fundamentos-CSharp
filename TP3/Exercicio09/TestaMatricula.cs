namespace Exercicio09;

class TestaMatricula {
    static void Main(string[] args) {
        Matricula matricula = new Matricula("Bruno", "EDS", 10001, "Ativa", "17/03/2025");
        
        matricula.ExibirInformacoes();
        matricula.Trancar();
        matricula.ExibirInformacoes();
        matricula.Reativar();
        matricula.ExibirInformacoes();
        
        
    }
}