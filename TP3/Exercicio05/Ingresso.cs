namespace Exercicio05;

public class Ingresso {
    
    public string NomeDoShow;
    public double Preco;
    public int QuantidadeDisponivel;

    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel) {
        NomeDoShow = nomeDoShow;
        Preco = preco;
        QuantidadeDisponivel = quantidadeDisponivel;
    }
    
    public string GetNomeDoShow() => NomeDoShow;
    public double GetPreco() => Preco;
    public int GetQuantidadeDisponivel() => QuantidadeDisponivel;

    public void SetNomeDoShow(string novoNome) {
        if (!String.IsNullOrEmpty(novoNome)) {
            NomeDoShow = novoNome;
            Console.WriteLine($"Nome do show atualizado para: {NomeDoShow}");
        } else {
            Console.WriteLine("Erro. O nome não pode ser vazio.");
        }
    }

    public void SetPreco(double novoPreco) {
        if (novoPreco > 0) {
            Preco = novoPreco;
            Console.WriteLine($"Preço atualizado para: {Preco}");
        } else {
            Console.WriteLine("Preço deve ser maior que zero.");
        }
    }

    public void SetQuantidadeDisponivel(int novaQtd) {
        if (novaQtd >= 0) {
            QuantidadeDisponivel = novaQtd;
            Console.WriteLine($"Quantidade disponível atualizada para: {QuantidadeDisponivel}");
        } else {
            Console.WriteLine($"Quantidade deve ser positiva.");
        }
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
        Console.WriteLine($"Preco: R${Preco:F2}");
        Console.WriteLine($"Ingressos disponíveis: {QuantidadeDisponivel}");
        Console.WriteLine($"=======================");
    }
    
}