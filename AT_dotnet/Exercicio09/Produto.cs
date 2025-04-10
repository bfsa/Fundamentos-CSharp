using System.Globalization;

namespace Exercicio09;

public class Produto {
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, int quantidade, decimal preco) {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public override string ToString() {
        return $"Produto: {Nome} | Quantidade: {Quantidade} | Preço: R$ {Preco:F2}";
    }

    public string ToFileFormat() {
        return $"{Nome},{Quantidade},{Preco.ToString(CultureInfo.InvariantCulture)}";
    }

    public static Produto FromFileFormat(string line) {
        string[] parts = line.Split(',');
        if (parts.Length != 3) {
            throw new FormatException("Formato de linha inválido no arquivo de estoque");
        }

        string nome = parts[0];

        if (!int.TryParse(parts[1], out int quantidade)) {
            throw new FormatException("Quantidade inválida no arquivo de estoque");
        }

        if (!decimal.TryParse(parts[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal preco)) {
            throw new FormatException("Preço inválido no arquivo de estoque");
        }

        return new Produto(nome, quantidade, preco);
    }
}