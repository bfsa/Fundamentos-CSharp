using System.Globalization;

namespace Exercicio09;

class Program {
    private const string ArquivoEstoque = "estoque.txt";
    private const int LimiteProdutos = 5;

    static void Main(string[] args) {
        int opcao;

        do {
            ExibirMenu();

            if (!int.TryParse(Console.ReadLine(), out opcao)) {
                Console.WriteLine("Opção inválida! Tente novamente.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            Console.Clear();

            switch (opcao) {
                case 1:
                    InserirProduto();
                    break;
                case 2:
                    ListarProdutos();
                    break;
                case 3:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (opcao != 3) {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        } while (opcao != 3);
    }

    static void ExibirMenu() {
        Console.WriteLine("===== CONTROLE DE ESTOQUE =====");
        Console.WriteLine("1. Inserir Produto");
        Console.WriteLine("2. Listar Produtos");
        Console.WriteLine("3. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void InserirProduto() {
        // Verificar se já atingiu o limite de produtos
        int quantidadeProdutos = ContarProdutosArquivo();

        if (quantidadeProdutos >= LimiteProdutos) {
            Console.WriteLine("Limite de produtos atingido!");
            return;
        }

        Console.WriteLine("===== INSERIR NOVO PRODUTO =====");

        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();

        int quantidade;
        decimal preco;

        do {
            Console.Write("Quantidade em estoque: ");
        } while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0);

        do {
            Console.Write("Preço unitário (R$): ");
        } while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.CurrentCulture, out preco) ||
                 preco < 0);

        Produto novoProduto = new Produto(nome, quantidade, preco);

        // Salvar o produto no arquivo 
        try {
            using (StreamWriter writer = new StreamWriter(ArquivoEstoque, true)) {
                writer.WriteLine(novoProduto.ToFileFormat());
            }

            Console.WriteLine("\nProduto cadastrado com sucesso!");
        }
        catch (Exception ex) {
            Console.WriteLine($"Erro ao salvar o produto: {ex.Message}");
        }
    }

    static void ListarProdutos() {
        Console.WriteLine("===== PRODUTOS CADASTRADOS =====");

        if (!File.Exists(ArquivoEstoque)) {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        try {
            List<Produto> produtos = new List<Produto>();

            using (StreamReader reader = new StreamReader(ArquivoEstoque)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    if (!string.IsNullOrWhiteSpace(line)) {
                        produtos.Add(Produto.FromFileFormat(line));
                    }
                }
            }

            if (produtos.Count == 0) {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            foreach (var produto in produtos) {
                Console.WriteLine(produto);
            }

            Console.WriteLine($"\nTotal de produtos cadastrados: {produtos.Count}");
        }
        catch (Exception ex) {
            Console.WriteLine($"Erro ao ler os produtos: {ex.Message}");
        }
    }

    static int ContarProdutosArquivo() {
        if (!File.Exists(ArquivoEstoque)) {
            return 0;
        }

        try {
            int count = 0;

            using (StreamReader reader = new StreamReader(ArquivoEstoque)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    if (!string.IsNullOrWhiteSpace(line)) {
                        count++;
                    }
                }
            }

            return count;
        }
        catch (Exception) {
            // Em caso de erro na leitura do arquivo, assumimos 0 produtos
            return 0;
        }
    }
}