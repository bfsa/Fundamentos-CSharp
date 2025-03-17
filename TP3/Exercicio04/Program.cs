namespace Exercicio04;

class Program {
    static void Main(string[] args) {
        
        Ingresso ingresso = new Ingresso("Charlie Brown Jr.", 42, 100);
        
        ingresso.ExibirInformacoes();
        ingresso.AlterarPreco(420);
        ingresso.AlterarQuantidade(1000);
        ingresso.ExibirInformacoes();
        
    }
}