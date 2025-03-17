namespace Exercicio06;

class Program {
    static void Main(string[] args) {
        Ingresso ingresso = new Ingresso("Charlie Brown Jr.", 42, 100);
        
        ingresso.ExibirInformacoes();
        ingresso.SetPreco(200.0);
        ingresso.GetPreco();
        ingresso.SetNomeDoShow("CBJR");
        ingresso.GetNomeDoShow();
        ingresso.SetQuantidadeDisponivel(500);
        ingresso.GetQuantidadeDisponivel();
        ingresso.ExibirInformacoes();

    }
}