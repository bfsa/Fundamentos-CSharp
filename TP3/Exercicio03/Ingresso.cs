namespace Exercicio03;

public class Ingresso {
    
    public String NomeDoShow;
    public double Preco;
    public int QuantidadeDisponivel;

    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel) {
        NomeDoShow = nomeDoShow;
        Preco = preco;
        QuantidadeDisponivel = quantidadeDisponivel;
    }

    public void AlterarPreco(double novoPreco) {
        if (novoPreco > 0) {
            Preco = novoPreco;
            Console.WriteLine($"Preço atualizado para R${Preco:F2}");
        } else {
            Console.WriteLine("Preço deve ser maior que zero");
        }
    }

    public void AlterarQuantidade(int novaQuantidade) {
        if (novaQuantidade > 0) {
            QuantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"Quantidade de ingressos disponíveis atualizada para: {QuantidadeDisponivel}.");
        } else {
            Console.WriteLine("Erro! A quantidade não pode ser negativa.");
        }
    }

    public void ExibirInformacoes() {
        Console.WriteLine($"=======================");
        Console.WriteLine($"Show: {NomeDoShow}");
        Console.WriteLine($"Preco: {Preco:F2}");
        Console.WriteLine($"Ingressos disponíveis: {QuantidadeDisponivel}");
        Console.WriteLine($"=======================");
    }
    
}